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
        int counter;
        int donation;

        public PrincipalWindow()
        {
            InitializeComponent();
            counter = 0;
            donation = 0;
        }

        // FORM - LOAD
        private void PrincipalWindow_Load(object sender, EventArgs e)
        { this.Text = "Optimal Decision"; }

        private void Next_Click(object sender, EventArgs e)
        {
            Decision decisionWindow = new Decision();
            decisionWindow.FormClosing += new FormClosingEventHandler(FormPrincipal_FormClosing);
            this.Hide();
            decisionWindow.Show();
        }

        private void FormPrincipal_FormClosing(object sender, EventArgs e)
        {
            this.Show();
            counter++;
            txt_Counter.Text = counter.ToString();
        }

        // DROP DOWN MENU

        private void donarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks a lot! :)");
            donation += 1000;
            txt_donation.Text = donation.ToString();
        }

        private void cerrarXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Close the App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
