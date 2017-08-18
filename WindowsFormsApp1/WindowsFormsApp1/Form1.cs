using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pantalla;

namespace Aplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Text = "Form2"; 
            InitializeComponent();
        }

        private void before_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

    }
}
