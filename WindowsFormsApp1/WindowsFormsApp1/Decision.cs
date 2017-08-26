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
        public int StandardCounter { get; set; }
        public DecisionProblem ActualDecision = new DecisionProblem();
        public List<Entidades.Standard> StandardList = new List<Entidades.Standard>();

        public Decision()
        {
            InitializeComponent();
        }

        private void btn_before_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Decision_Load(object sender, EventArgs e)
        {
            btn_before.Enabled = false;
            txt_ProblemDate.Text = DateTime.Today.ToShortDateString();
            pbox_interrogation.Image = Image.FromFile(Path.Combine(Application.StartupPath, @"Images\interrogation.jpg"));

            // StandardList.Add()
            LoadStandars();
        }

        // COMBO BOX STANDARD
        protected void LoadStandars()
        {
            Entidades.Standard Default = new Entidades.Standard(null, "< Seleccionar >", "");
            StandardList = StandardDao.GetStandards();
            StandardList.Insert(0, Default);
            cbo_Standars.DataSource = StandardList;
            cbo_Standars.DisplayMember = "Name";
            cbo_Standars.ValueMember = "IdStandard";
            cbo_Standars.SelectedIndex = 0;
        }

        private void cbo_Standars_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_StandardDescription.Text = ((Entidades.Standard)cbo_Standars.SelectedItem).Description.ToString();
        }

        private void CreateDefaultStandard()
        {
            Entidades.Standard Default = new Entidades.Standard(null, "Seleccionar", "");
            StandardList.Add(Default);
        }

        //private void textBox_TextChanged(object sender, EventArgs e)
        //{
        //    var bl = !string.IsNullOrEmpty(txt_DecisionProblem.Text) && !string.IsNullOrEmpty(txt_StandardName.Text);
        //    btn_before.Enabled = bl;
        //}

        private void addStandard_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            { MessageBox.Show("Debe completar los campos requeridos(*) para continuar.", "Optimal Decision", MessageBoxButtons.OK); }
            else
            {
                if (StandardCounter < 7)
                {
                    ActualDecision.Name = txt_DecisionProblem.Text;
                    ActualDecision.Date = DateTime.Today;
                    listView_Standard.Items.Add(((Entidades.Standard)cbo_Standars.SelectedItem).Name.ToString());
                    StandardCounter++;
                    cbo_Standars.SelectedIndex = 0;
                    txt_StandardDescription.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("No se recomienda agregar más de 7 Criterios por decisión.", "Optimal Decision", MessageBoxButtons.OK);
                }
            }
        }

        protected bool ValidarCampos()
        {
            bool bandera = true;
            if (txt_DecisionProblem.Text == String.Empty || cbo_Standars.SelectedIndex == 0)
            {
                bandera = false;
                return bandera;
            }
            return bandera;
        }

        private void btn_newStandard_Click(object sender, EventArgs e)
        {
            AdminStandards adminStandards = new AdminStandards();
            adminStandards.ShowDialog();
            LoadStandars();
        }
    }
}

