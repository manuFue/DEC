namespace Aplication
{
    partial class Decision
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Decision));
            this.btn_before = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_StandardDescription = new System.Windows.Forms.TextBox();
            this.lbl_Standards = new System.Windows.Forms.Label();
            this.listView_Standard = new System.Windows.Forms.ListView();
            this.addStandard = new System.Windows.Forms.Button();
            this.gbox_Standards = new System.Windows.Forms.GroupBox();
            this.btn_newStandard = new System.Windows.Forms.Button();
            this.cbo_Standars = new System.Windows.Forms.ComboBox();
            this.lbl_StandardList = new System.Windows.Forms.Label();
            this.lbl_DecisionName = new System.Windows.Forms.Label();
            this.txt_DecisionProblem = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.txt_ProblemDate = new System.Windows.Forms.TextBox();
            this.lbl_ProblemImportant = new System.Windows.Forms.Label();
            this.lbl_StandardMax = new System.Windows.Forms.Label();
            this.pbox_interrogation = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.gbox_Standards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_interrogation)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_before
            // 
            this.btn_before.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_before.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_before.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_before.Location = new System.Drawing.Point(435, 0);
            this.btn_before.Name = "btn_before";
            this.btn_before.Size = new System.Drawing.Size(80, 23);
            this.btn_before.TabIndex = 0;
            this.btn_before.Text = "VOLVER";
            this.btn_before.UseVisualStyleBackColor = false;
            this.btn_before.Click += new System.EventHandler(this.btn_before_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // txt_StandardDescription
            // 
            this.txt_StandardDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_StandardDescription.Enabled = false;
            this.txt_StandardDescription.Location = new System.Drawing.Point(6, 45);
            this.txt_StandardDescription.Multiline = true;
            this.txt_StandardDescription.Name = "txt_StandardDescription";
            this.txt_StandardDescription.Size = new System.Drawing.Size(210, 44);
            this.txt_StandardDescription.TabIndex = 16;
            // 
            // lbl_Standards
            // 
            this.lbl_Standards.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Standards.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Standards.Location = new System.Drawing.Point(10, 155);
            this.lbl_Standards.Name = "lbl_Standards";
            this.lbl_Standards.Size = new System.Drawing.Size(113, 35);
            this.lbl_Standards.TabIndex = 12;
            this.lbl_Standards.Text = "Criterios";
            this.lbl_Standards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Standards.UseMnemonic = false;
            // 
            // listView_Standard
            // 
            this.listView_Standard.Location = new System.Drawing.Point(323, 42);
            this.listView_Standard.Name = "listView_Standard";
            this.listView_Standard.Size = new System.Drawing.Size(174, 112);
            this.listView_Standard.TabIndex = 11;
            this.listView_Standard.UseCompatibleStateImageBehavior = false;
            this.listView_Standard.View = System.Windows.Forms.View.List;
            // 
            // addStandard
            // 
            this.addStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStandard.Location = new System.Drawing.Point(6, 95);
            this.addStandard.Name = "addStandard";
            this.addStandard.Size = new System.Drawing.Size(210, 34);
            this.addStandard.TabIndex = 10;
            this.addStandard.Text = "Agregar Criterio";
            this.addStandard.UseVisualStyleBackColor = true;
            this.addStandard.Click += new System.EventHandler(this.addStandard_Click);
            // 
            // gbox_Standards
            // 
            this.gbox_Standards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_Standards.Controls.Add(this.btn_newStandard);
            this.gbox_Standards.Controls.Add(this.cbo_Standars);
            this.gbox_Standards.Controls.Add(this.lbl_StandardList);
            this.gbox_Standards.Controls.Add(this.txt_StandardDescription);
            this.gbox_Standards.Controls.Add(this.listView_Standard);
            this.gbox_Standards.Controls.Add(this.addStandard);
            this.gbox_Standards.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_Standards.Location = new System.Drawing.Point(12, 193);
            this.gbox_Standards.Name = "gbox_Standards";
            this.gbox_Standards.Size = new System.Drawing.Size(503, 177);
            this.gbox_Standards.TabIndex = 17;
            this.gbox_Standards.TabStop = false;
            // 
            // btn_newStandard
            // 
            this.btn_newStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newStandard.Location = new System.Drawing.Point(165, 11);
            this.btn_newStandard.Name = "btn_newStandard";
            this.btn_newStandard.Size = new System.Drawing.Size(145, 33);
            this.btn_newStandard.TabIndex = 22;
            this.btn_newStandard.Text = "Nuevo Criterio";
            this.btn_newStandard.UseVisualStyleBackColor = true;
            this.btn_newStandard.Click += new System.EventHandler(this.btn_newStandard_Click);
            // 
            // cbo_Standars
            // 
            this.cbo_Standars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Standars.Font = new System.Drawing.Font("Lemon/Milk", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Standars.FormattingEnabled = true;
            this.cbo_Standars.Location = new System.Drawing.Point(6, 16);
            this.cbo_Standars.Name = "cbo_Standars";
            this.cbo_Standars.Size = new System.Drawing.Size(153, 23);
            this.cbo_Standars.TabIndex = 18;
            this.cbo_Standars.SelectedIndexChanged += new System.EventHandler(this.cbo_Standars_SelectedIndexChanged);
            // 
            // lbl_StandardList
            // 
            this.lbl_StandardList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StandardList.Location = new System.Drawing.Point(321, 11);
            this.lbl_StandardList.Name = "lbl_StandardList";
            this.lbl_StandardList.Size = new System.Drawing.Size(133, 23);
            this.lbl_StandardList.TabIndex = 17;
            this.lbl_StandardList.Text = "Lista de Criterios";
            this.lbl_StandardList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DecisionName
            // 
            this.lbl_DecisionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DecisionName.Location = new System.Drawing.Point(27, 78);
            this.lbl_DecisionName.Name = "lbl_DecisionName";
            this.lbl_DecisionName.Size = new System.Drawing.Size(157, 23);
            this.lbl_DecisionName.TabIndex = 17;
            this.lbl_DecisionName.Text = "Problema de Decisión:";
            this.lbl_DecisionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_DecisionProblem
            // 
            this.txt_DecisionProblem.Location = new System.Drawing.Point(27, 105);
            this.txt_DecisionProblem.Name = "txt_DecisionProblem";
            this.txt_DecisionProblem.Size = new System.Drawing.Size(223, 20);
            this.txt_DecisionProblem.TabIndex = 17;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(27, 128);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(52, 23);
            this.lbl_Date.TabIndex = 18;
            this.lbl_Date.Text = "Fecha:";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ProblemDate
            // 
            this.txt_ProblemDate.Enabled = false;
            this.txt_ProblemDate.Location = new System.Drawing.Point(85, 131);
            this.txt_ProblemDate.Name = "txt_ProblemDate";
            this.txt_ProblemDate.Size = new System.Drawing.Size(68, 20);
            this.txt_ProblemDate.TabIndex = 19;
            // 
            // lbl_ProblemImportant
            // 
            this.lbl_ProblemImportant.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProblemImportant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ProblemImportant.Location = new System.Drawing.Point(10, 43);
            this.lbl_ProblemImportant.Name = "lbl_ProblemImportant";
            this.lbl_ProblemImportant.Size = new System.Drawing.Size(121, 35);
            this.lbl_ProblemImportant.TabIndex = 20;
            this.lbl_ProblemImportant.Text = "Problema";
            this.lbl_ProblemImportant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ProblemImportant.UseMnemonic = false;
            // 
            // lbl_StandardMax
            // 
            this.lbl_StandardMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StandardMax.Location = new System.Drawing.Point(117, 164);
            this.lbl_StandardMax.Name = "lbl_StandardMax";
            this.lbl_StandardMax.Size = new System.Drawing.Size(73, 23);
            this.lbl_StandardMax.TabIndex = 18;
            this.lbl_StandardMax.Text = "( máx. 7 )";
            this.lbl_StandardMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbox_interrogation
            // 
            this.pbox_interrogation.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbox_interrogation.InitialImage")));
            this.pbox_interrogation.Location = new System.Drawing.Point(336, 33);
            this.pbox_interrogation.Name = "pbox_interrogation";
            this.pbox_interrogation.Size = new System.Drawing.Size(160, 161);
            this.pbox_interrogation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_interrogation.TabIndex = 21;
            this.pbox_interrogation.TabStop = false;
            // 
            // Decision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 414);
            this.Controls.Add(this.pbox_interrogation);
            this.Controls.Add(this.lbl_StandardMax);
            this.Controls.Add(this.lbl_ProblemImportant);
            this.Controls.Add(this.txt_ProblemDate);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.txt_DecisionProblem);
            this.Controls.Add(this.lbl_DecisionName);
            this.Controls.Add(this.gbox_Standards);
            this.Controls.Add(this.lbl_Standards);
            this.Controls.Add(this.btn_before);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Decision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Decisión";
            this.Load += new System.EventHandler(this.Decision_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbox_Standards.ResumeLayout(false);
            this.gbox_Standards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_interrogation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.Button btn_before;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_StandardDescription;
        private System.Windows.Forms.Label lbl_Standards;
        private System.Windows.Forms.ListView listView_Standard;
        private System.Windows.Forms.Button addStandard;
        private System.Windows.Forms.GroupBox gbox_Standards;
        private System.Windows.Forms.Label lbl_DecisionName;
        private System.Windows.Forms.TextBox txt_DecisionProblem;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox txt_ProblemDate;
        private System.Windows.Forms.Label lbl_ProblemImportant;
        private System.Windows.Forms.Label lbl_StandardList;
        private System.Windows.Forms.Label lbl_StandardMax;
        private System.Windows.Forms.PictureBox pbox_interrogation;
        private System.Windows.Forms.Button btn_newStandard;
        private System.Windows.Forms.ComboBox cbo_Standars;
    }
}