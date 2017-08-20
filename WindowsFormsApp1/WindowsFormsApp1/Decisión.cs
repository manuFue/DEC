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

namespace Aplication
{
    public partial class Decision : Form
    {
        public Decision()
        { 
            InitializeComponent();
        }

        private void before_Click(object sender, EventArgs e)
        {
            this.Close();          
        }
    }
}
