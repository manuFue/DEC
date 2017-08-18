using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion;

namespace Pantalla
{
    public partial class PantallaPrincipal : Form
    {
        int counter;
        int donation;

        public PantallaPrincipal()
        {
            InitializeComponent();
            counter = 0;
            donation = 0;
        }

        

        private void Next_Click(object sender, EventArgs e)
        {
            Form1 ventanaPrueba = new Form1();
            ventanaPrueba.FormClosing += new FormClosingEventHandler(FormPrincipal_FormClosing);
            this.Hide();
            ventanaPrueba.Show();
        }

        private void FormPrincipal_FormClosing(object sender, EventArgs e)
        {
            this.Show();
            counter++;
            txtBox_Contador.Text = counter.ToString();
        }

        private void donarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muchas Gracias! :)");
            donation += 1000;
            txt_donacion.Text = donation.ToString(); 
        }

        private void cerrarXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Cerrar la Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
