using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplication;

namespace Window
{
    public partial class PrincipalWindow : Form
    {
        public PrincipalWindow()
        {
            InitializeComponent();
        }

        // FORM - LOAD
        private void PrincipalWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void FormPrincipal_FormClosing(object sender, EventArgs e)
        {
            this.Show();
        }

        // DROP DOWN MENU

        private void cerrarXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quiere cerrar la aplicación?", "Optimal Decision", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void nuevaDecisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decision decisionWindow = new Decision();
            decisionWindow.FormClosing += new FormClosingEventHandler(FormPrincipal_FormClosing);
            this.Hide();
            decisionWindow.Show();
        }

        private void administrarCriteriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminStandards adminStandards = new AdminStandards();
            adminStandards.ShowDialog();
        }
    }
}
