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

namespace Pantalla
{
    public partial class Options : Form
    {
        private int value;

        public Options()
        {
            InitializeComponent();
            this.value = -1;
            this.ControlBox = false;
        }
        
        public int getValue()
        {
            return value;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton thisButton = sender as RadioButton;
            value = 3;
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton thisButton = sender as RadioButton;
            value = 5;
            this.Close();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton thisButton = sender as RadioButton;
            value = 7;
            this.Close();
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton thisButton = sender as RadioButton;
            value = 9;
            this.Close();
        }

    }
}
