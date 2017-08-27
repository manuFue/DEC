using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dao;
using Entidades;

namespace Pantalla
{
    public partial class StandardsPreference : Form
    {
        public List<Entidades.Standard> standardList;
        public Entidades.Standard mainStandard;
        public int DecisionID;

        public StandardsPreference(int decisionID, List<Entidades.Standard> StandardList)
        {
            InitializeComponent();
            this.standardList = StandardList;
            this.mainStandard = StandardList[0];
            this.DecisionID = decisionID;
        }

        private void StandardsPreference_Load(object sender, EventArgs e)
        {
            StandardPreferencesEntity StandardPreferences = new StandardPreferencesEntity();
            StandardPreferences.mainStandard = this.mainStandard;
            standardList.RemoveAt(0);
            int standarCounter = 15;

            foreach (Entidades.Standard standards in standardList)
            {
                Label lbl_Date = new System.Windows.Forms.Label();
                lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbl_Date.Location = new System.Drawing.Point(10, standarCounter);
                lbl_Date.Name = "lbl_Title";
                lbl_Date.Size = new System.Drawing.Size(400, 23);
                lbl_Date.Text = "Preferencia de " + mainStandard.Name.ToString() + " por sobre " + standards.Name.ToString() + ":";
                lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                Controls.Add(lbl_Date);
                standarCounter += 60;
            }
        }
    }
}

