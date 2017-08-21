﻿using System;
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
            ///Image DecisionImage = new Bitmap(Path.Combine(Application.StartupPath, @"Images\interrogation.jpg"));
            txt_ProblemDate.Text = DateTime.Today.ToShortDateString();
            //string imagePath = Path.Combine(Application.StartupPath, "Images\interrogation.jpg");
            pbox_interrogation.Image = Image.FromFile(Path.Combine(Application.StartupPath, @"Images\interrogation.jpg"));
        }

        private void addStandard_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            { MessageBox.Show("Debe completar los campos requeridos(*) para continuar.", "Optimal Decision", MessageBoxButtons.OK); }
            else
            {
                if (StandardCounter < 7)
                {
                    ActualDecision.Date = DateTime.Today;
                    listView_Standard.Items.Add(txt_StandardName.Text, StandardCounter + 1);
                    StandardCounter++;
                    txt_StandardName.Text = String.Empty;
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
            if (txt_DecisionProblem.Text == String.Empty || txt_StandardName.Text == String.Empty)
            {
                bandera = false;
                return bandera;
            }
            return bandera;
        }

    }
}

