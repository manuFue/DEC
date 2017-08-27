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
        public Entidades.Standard ActualStandard = new Entidades.Standard();

        public AdminStandards()
        {
            InitializeComponent();
        }

        // LOAD
        private void AdminStandards_Load(object sender, EventArgs e)
        {
            updateStandards(StandardDao.GetStandards());
        }

        // UPDATE DATA GRID VIEW
        private void updateStandards(List<Entidades.Standard> standardCollection)
        {
            dgv_standards.Rows.Clear();
            foreach (Entidades.Standard standard in standardCollection)
            {
                dgv_standards.Rows.Add(standard.IdStandard, standard.Name, standard.Description);
                dgv_standards.Columns[0].Visible = false;
            }
            dgv_standards.ClearSelection();
        }

        // BUTTONS
        private void btn_ready_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            { MessageBox.Show("Debe ingresar un Nombre y Descripción para continuar.", "Optimal Decision", MessageBoxButtons.OK); }
            else
            {
                ActualStandard.Name = txt_Name.Text;
                ActualStandard.Description = txt_Description.Text;
                if (StandardDao.Insert(ActualStandard) != null)
                    MessageBox.Show("¡Se ha creado el criterio con éxito!", "Optimal Decision", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Ha un ocurrido un error, no se ha podido crear el criterio.", "Optimal Decision", MessageBoxButtons.OK);
                updateStandards(StandardDao.GetStandards());
                txt_Name.Clear();
                txt_Description.Clear();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            updateStandards(StandardDao.GetStandards(txt_search.Text));
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar este criterio?", "Optimal Decision", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
            {
                StandardDao.Delete(int.Parse(dgv_standards.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Criterio Eliminado con éxito.", "Optimal Decision", MessageBoxButtons.OK);
                updateStandards(StandardDao.GetStandards());
            }
            if (dgv_standards.Rows.Count == 0)
            {
                btn_delete.BackColor = System.Drawing.Color.DarkGray;
                btn_delete.Enabled = true;
            }
        }

        // OTHER
        private void dgv_Standards_CellClick(object sender, EventArgs e)
        {
            btn_delete.Enabled = true;
            btn_delete.BackColor = System.Drawing.Color.LightCoral;
        }

        protected bool ValidarCampos()
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
