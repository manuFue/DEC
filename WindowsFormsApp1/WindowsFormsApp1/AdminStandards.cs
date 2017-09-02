using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Dao;

namespace Aplication
{
    public partial class AdminStandards : Form
    {
        public Entidades.Standard actualStandard = new Entidades.Standard();
        public bool optimizacionValue = true;

        public AdminStandards()
        {
            InitializeComponent();
        }

        // LOAD
        private void adminStandards_Load(object sender, EventArgs e)
        {
            updateStandards(StandardDao.GetStandards());
        }

        private void loadStandard(int ID)
        {
            actualStandard = StandardDao.GetByID(ID);
            txt_Name.Text = actualStandard.Name.ToString().ToUpper();
            txt_Description.Text = actualStandard.Description.ToString();
            if (actualStandard.Optimization)
                radiob_max.Checked = true;
            else
                radiob_min.Checked = true;
            btn_modify.Enabled = true;
            btn_modify.BackColor = System.Drawing.Color.Goldenrod;
        }

        // UPDATES
        private void updateStandards(List<Entidades.Standard> standardCollection)
        {
            dgv_standards.Rows.Clear();
            foreach (Entidades.Standard standard in standardCollection)
            {
                dgv_standards.Rows.Add(standard.IdStandard, standard.Name, standard.Description, optimizationWay(standard.Optimization));
                dgv_standards.Columns[0].Visible = false;
            }
            disableDelete();
        }

        private void clearFields()
        {
            txt_Description.Text = String.Empty;
            txt_Name.Text = String.Empty;
            radiob_max.Checked = true;
            disableModify();
        }

        // BUTTONS
        private void btn_ready_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if (!validateFields())
            { MessageBox.Show("Debe ingresar un Nombre y Descripción para continuar.", "Optimal Decision", MessageBoxButtons.OK); }
            else
            {
                actualStandard.Name = txt_Name.Text;
                actualStandard.Description = txt_Description.Text;
                actualStandard.Optimization = optimizacionValue;
                if (StandardDao.Insert(actualStandard) != null)
                    MessageBox.Show("¡Se ha creado el criterio con éxito!", "Optimal Decision", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Ha un ocurrido un error, no se ha podido crear el criterio.", "Optimal Decision", MessageBoxButtons.OK);
                updateStandards(StandardDao.GetStandards());
                clearFields();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar este criterio?", "Optimal Decision", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                StandardDao.Delete(int.Parse(dgv_standards.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Criterio Eliminado con éxito.", "Optimal Decision", MessageBoxButtons.OK);
                clearFields();
                updateStandards(StandardDao.GetStandards());
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            if (StandardDao.GetByID(int.Parse(dgv_standards.CurrentRow.Cells[0].Value.ToString())) != null)
            {
                actualStandard.Name = txt_Name.Text;
                actualStandard.Description = txt_Description.Text;
                actualStandard.Optimization = optimizacionValue;
                StandardDao.Update(actualStandard);
                clearFields();
                updateStandards(StandardDao.GetStandards());
            }
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            clearFields();
            disableDelete();
        }

        // OPTIMIZATION

        private void radiob_max_CheckedChanged(object sender, EventArgs e)
        {
            optimizacionValue = true;
        }

        private void radiob_min_CheckedChanged(object sender, EventArgs e)
        {
            optimizacionValue = false;
        }

        private string optimizationWay(bool standardOptimization)
        {
            if (standardOptimization)
                return "Maximizante";
            else
                return "Minimizante";
        }

        // DISABLE

        private void disableDelete()
        {
            dgv_standards.ClearSelection();
            btn_delete.Enabled = false;
            btn_delete.BackColor = System.Drawing.Color.DarkGray;
        }

        private void disableModify()
        {
            btn_modify.Enabled = false;
            btn_modify.BackColor = System.Drawing.Color.DarkGray;
        }

        // CHANGE        

        private void dgv_Standards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadStandard(int.Parse(dgv_standards.CurrentRow.Cells[0].Value.ToString()));

            btn_delete.Enabled = true;
            btn_delete.BackColor = System.Drawing.Color.LightCoral;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            clearFields();
            disableDelete();
            foreach (DataGridViewRow current in dgv_standards.Rows)
            {
                if ((current.Cells[1].Value.ToString().StartsWith(txt_search.Text, true, null)))
                    current.Visible = true;
                else
                    current.Visible = false;
            }
        }

        // OTHER

        protected bool validateFields()
        {
            bool bandera = true;
            if (txt_Name.Text == "" || txt_Description.Text == "")
            {
                bandera = false;
                return bandera;
            }
            return bandera;
        }

    }
}
