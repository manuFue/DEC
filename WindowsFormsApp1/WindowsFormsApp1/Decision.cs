using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window;
using Dao;
using Entidades;
using System.IO;

namespace Aplication
{
    public partial class Decision : Form
    {
        // VARIABLES
        public int StandardCounter { get; set; }
        public DecisionProblem ActualDecision = new DecisionProblem();
        public List<Entidades.Standard> StandardList = new List<Entidades.Standard>();
        public int DecisionID;

        // START COMPONENTS
        public Decision()
        {
            InitializeComponent();
        }

        //LOAD
        private void Decision_Load(object sender, EventArgs e)
        {
            if (DecisionDAO.Exists(1))
                DecisionID = int.Parse(DecisionDAO.MaxNumber().ToString()) + 1;
            else
                DecisionID = 1;

            txt_ProblemDate.Text = DateTime.Today.ToShortDateString();
            pbox_interrogation.Image = Image.FromFile(Path.Combine(Application.StartupPath, @"Images\interrogation.jpg"));
            pbox_backArrow.Image = Image.FromFile(Path.Combine(Application.StartupPath, @"Images\backArrowSmall.jpg"));
            LoadStandars();
            dgv_standards.RowHeadersVisible = false;
            dgv_standards.ColumnHeadersVisible = false;
            dgv_standards.Columns[0].Visible = false;
            dgv_standards.Columns[2].Visible = false;
        }

        // COMBO BOX STANDARD
        protected void LoadStandars()
        {
            Entidades.Standard Default = new Entidades.Standard(null, "< Seleccionar >", "", true);
            StandardList = StandardDao.GetStandards();
            StandardList.Insert(0, Default);
            if (dgv_standards.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgv_standards.Rows)
                {
                    StandardList.Remove(StandardList.Find(x => x.IdStandard == Convert.ToInt32(row.Cells[0].Value.ToString())));
                }
            }
            cbo_Standars.DataSource = null;
            cbo_Standars.DataSource = StandardList;
            cbo_Standars.DisplayMember = "Name";
            cbo_Standars.ValueMember = "IdStandard";
            cbo_Standars.SelectedIndex = 0;
            //refreshStandards();
        }

        //private void refreshStandards()
        //{
        //    cbo_Standars.DataSource = null;
        //    cbo_Standars.DataSource = StandardList;
        //    cbo_Standars.DisplayMember = "Name";
        //    cbo_Standars.ValueMember = "IdStandard";
        //    cbo_Standars.SelectedIndex = 0;
        //}

        private void cbo_Standars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_Standars.DataSource != null)
                txt_StandardDescription.Text = ((Entidades.Standard)cbo_Standars.SelectedItem).Description.ToString();
        }

        //private void CreateDefaultStandard()
        //{
        //    Entidades.Standard Default = new Entidades.Standard(null, "Seleccionar", "", true);
        //    StandardList.Add(Default);
        //}

        // OTHERS
        protected bool ValidarCampos()
        {
            bool bandera = true;
            if (cbo_Standars.SelectedIndex == 0)
            {
                bandera = false;
                return bandera;
            }
            return bandera;
        }

        private void dgv_Standards_CellClick(object sender, EventArgs e)
        {
            btn_delete.Enabled = true;
            btn_delete.BackColor = System.Drawing.Color.LightCoral;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // PICTURE BOXES
        private void pbox_backArrow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // BUTTONS
        private void addStandard_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            { MessageBox.Show("Debe elegir un criterio para continuar.", "Optimal Decision", MessageBoxButtons.OK); }
            else
            {
                if (StandardCounter < 7)
                {
                    bool flag = true;
                    foreach (DataGridViewRow row in dgv_standards.Rows)
                    {
                        if (int.Parse(row.Cells[0].Value.ToString()) == int.Parse(cbo_Standars.SelectedValue.ToString()))
                            flag = false;
                    }
                    if (flag)
                    {
                        Entidades.Standard selectedStandard = ((Entidades.Standard)cbo_Standars.SelectedItem);
                        dgv_standards.Rows.Add(selectedStandard.IdStandard, selectedStandard.Name, selectedStandard.Description);
                        dgv_standards.ClearSelection();
                        StandardCounter++;

                        //StandardList.Remove(StandardList.Find(x => x.IdStandard == selectedStandard.IdStandard));
                        //refreshStandards();
                        LoadStandars();
                        txt_StandardDescription.Text = String.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Ese criterio ya se ha agregado al problema de decisión", "Optimal Decision", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("No se recomienda agregar más de 7 Criterios por decisión.", "Optimal Decision", MessageBoxButtons.OK);
                }
            }
        }

        private void btn_adminStandars_Click(object sender, EventArgs e)
        {
            AdminStandards adminStandards = new AdminStandards();
            adminStandards.ShowDialog();
            LoadStandars();
        }

        private void btn_value_Click(object sender, EventArgs e)
        {
            if (txt_DecisionProblem.Text == "")
                MessageBox.Show("Por favor ingrese un nombre para el problema de decisión.", "Optimal Decision", MessageBoxButtons.OK);
            else if (dgv_standards.Rows.Count < 4)
                MessageBox.Show("Debe seleccionar al menos 4 criterios para el problema de decisión.", "Optimal Decision", MessageBoxButtons.OK);
            else
            {
                if (MessageBox.Show("Una vez valorados los criterios no podrá agregar ni quitar ningún criterio del problema." + Environment.NewLine + " ¿Desea continuar?", "Optimal Decision", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ActualDecision.IdProblem = DecisionID;
                    ActualDecision.Name = txt_DecisionProblem.Text;
                    ActualDecision.Date = DateTime.Today;
                    List<Entidades.Standard> selectedStandards = new List<Entidades.Standard>();

                    foreach (DataGridViewRow row in dgv_standards.Rows)
                    {
                        selectedStandards.Add(StandardDao.GetByID(int.Parse(row.Cells[0].Value.ToString())));
                    }

                    ActualDecision.StandardList = selectedStandards;

                    Pantalla.StandardsPreference preferencesWindow = new Pantalla.StandardsPreference(ActualDecision, ActualDecision.StandardList);
                    preferencesWindow.ShowDialog();


                    // CALCULAR PESOS CON ESA LISTA DE PREFERENCIAS SOBRE LOS CRITERIOS
                    preferencesWindow.getStandardPreferencesList();

                    btn_delete.Enabled = false;
                    btn_adminStandards.Enabled = false;
                    btn_addStandard.Enabled = false;
                    btn_value.Enabled = false;
                    cbo_Standars.Enabled = false;
                    btn_adminStandards.BackColor = System.Drawing.Color.DarkGray;
                    btn_delete.BackColor = System.Drawing.Color.DarkGray;
                    btn_addStandard.BackColor = System.Drawing.Color.DarkGray;
                    btn_value.BackColor = System.Drawing.Color.DarkGray;

                    btn_generateAlternatives.Enabled = true;
                    btn_generateAlternatives.BackColor = System.Drawing.Color.LightSalmon;
                }
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_standards.Rows.Count != 0)
            {
                dgv_standards.Rows.Remove(dgv_standards.CurrentRow);
                LoadStandars();
            }
                
            StandardCounter--;
            if (StandardCounter == 0)
            {
                btn_delete.Enabled = false;
                btn_delete.BackColor = System.Drawing.Color.DarkGray;
            }
        }


    }
}

