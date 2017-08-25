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
    public partial class New_Standard : Form
    {
        public Entidades.Standard ActualStandard = new Entidades.Standard();
        public New_Standard()
        {
            InitializeComponent();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            ActualStandard.Name = txt_Name.Text;
            ActualStandard.Description = txt_Description.Text;
            if(StandardDao.Insertar(ActualStandard) != null)
                MessageBox.Show("¡Se ha creado el criterio con éxito!", "Optimal Decision", MessageBoxButtons.OK);
            else
                MessageBox.Show("Ha un ocurrido un error, no se ha podido crear el criterio.", "Optimal Decision", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
