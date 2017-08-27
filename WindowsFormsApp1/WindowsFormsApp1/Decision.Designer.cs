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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Decision));
            this.txt_StandardDescription = new System.Windows.Forms.TextBox();
            this.lbl_Standards = new System.Windows.Forms.Label();
            this.btn_addStandard = new System.Windows.Forms.Button();
            this.gbox_Standards = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_standards = new System.Windows.Forms.DataGridView();
            this.IdStandard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_value = new System.Windows.Forms.Button();
            this.btn_adminStandards = new System.Windows.Forms.Button();
            this.cbo_Standars = new System.Windows.Forms.ComboBox();
            this.txt_DecisionProblem = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.txt_ProblemDate = new System.Windows.Forms.TextBox();
            this.lbl_ProblemImportant = new System.Windows.Forms.Label();
            this.lbl_StandardMax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbox_backArrow = new System.Windows.Forms.PictureBox();
            this.pbox_interrogation = new System.Windows.Forms.PictureBox();
            this.btn_generateAlternatives = new System.Windows.Forms.Button();
            this.gbox_Standards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_standards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_backArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_interrogation)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_StandardDescription
            // 
            this.txt_StandardDescription.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_StandardDescription.Enabled = false;
            this.txt_StandardDescription.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StandardDescription.Location = new System.Drawing.Point(6, 45);
            this.txt_StandardDescription.Multiline = true;
            this.txt_StandardDescription.Name = "txt_StandardDescription";
            this.txt_StandardDescription.Size = new System.Drawing.Size(298, 42);
            this.txt_StandardDescription.TabIndex = 16;
            // 
            // lbl_Standards
            // 
            this.lbl_Standards.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Standards.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Standards.Location = new System.Drawing.Point(10, 151);
            this.lbl_Standards.Name = "lbl_Standards";
            this.lbl_Standards.Size = new System.Drawing.Size(113, 35);
            this.lbl_Standards.TabIndex = 12;
            this.lbl_Standards.Text = "Criterios";
            this.lbl_Standards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Standards.UseMnemonic = false;
            // 
            // btn_addStandard
            // 
            this.btn_addStandard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_addStandard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addStandard.Location = new System.Drawing.Point(6, 93);
            this.btn_addStandard.Name = "btn_addStandard";
            this.btn_addStandard.Size = new System.Drawing.Size(135, 29);
            this.btn_addStandard.TabIndex = 10;
            this.btn_addStandard.Text = "Agregar Criterio";
            this.btn_addStandard.UseVisualStyleBackColor = false;
            this.btn_addStandard.Click += new System.EventHandler(this.addStandard_Click);
            // 
            // gbox_Standards
            // 
            this.gbox_Standards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_Standards.Controls.Add(this.btn_delete);
            this.gbox_Standards.Controls.Add(this.dgv_standards);
            this.gbox_Standards.Controls.Add(this.btn_value);
            this.gbox_Standards.Controls.Add(this.btn_adminStandards);
            this.gbox_Standards.Controls.Add(this.cbo_Standars);
            this.gbox_Standards.Controls.Add(this.txt_StandardDescription);
            this.gbox_Standards.Controls.Add(this.btn_addStandard);
            this.gbox_Standards.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_Standards.Location = new System.Drawing.Point(12, 189);
            this.gbox_Standards.Name = "gbox_Standards";
            this.gbox_Standards.Size = new System.Drawing.Size(503, 231);
            this.gbox_Standards.TabIndex = 17;
            this.gbox_Standards.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DarkGray;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Enabled = false;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_delete.Location = new System.Drawing.Point(169, 93);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(135, 29);
            this.btn_delete.TabIndex = 39;
            this.btn_delete.Text = "Quitar Criterio";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_standards
            // 
            this.dgv_standards.AllowUserToAddRows = false;
            this.dgv_standards.AllowUserToDeleteRows = false;
            this.dgv_standards.AllowUserToResizeColumns = false;
            this.dgv_standards.AllowUserToResizeRows = false;
            this.dgv_standards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_standards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdStandard,
            this.name,
            this.description});
            this.dgv_standards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_standards.Location = new System.Drawing.Point(310, 16);
            this.dgv_standards.MultiSelect = false;
            this.dgv_standards.Name = "dgv_standards";
            this.dgv_standards.ReadOnly = true;
            this.dgv_standards.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_standards.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_standards.Size = new System.Drawing.Size(174, 157);
            this.dgv_standards.TabIndex = 38;
            this.dgv_standards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Standards_CellClick);
            // 
            // IdStandard
            // 
            this.IdStandard.HeaderText = "ID";
            this.IdStandard.Name = "IdStandard";
            this.IdStandard.ReadOnly = true;
            // 
            // name
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.name.DefaultCellStyle = dataGridViewCellStyle1;
            this.name.HeaderText = "Criterio";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 185;
            // 
            // description
            // 
            this.description.HeaderText = "Descripción";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // btn_value
            // 
            this.btn_value.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_value.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_value.Location = new System.Drawing.Point(310, 186);
            this.btn_value.Name = "btn_value";
            this.btn_value.Size = new System.Drawing.Size(174, 32);
            this.btn_value.TabIndex = 23;
            this.btn_value.Text = "Valorar Criterios";
            this.btn_value.UseVisualStyleBackColor = false;
            this.btn_value.Click += new System.EventHandler(this.btn_value_Click);
            // 
            // btn_adminStandards
            // 
            this.btn_adminStandards.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_adminStandards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adminStandards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adminStandards.Location = new System.Drawing.Point(157, 13);
            this.btn_adminStandards.Name = "btn_adminStandards";
            this.btn_adminStandards.Size = new System.Drawing.Size(147, 28);
            this.btn_adminStandards.TabIndex = 22;
            this.btn_adminStandards.Text = "Administrar Criterios";
            this.btn_adminStandards.UseVisualStyleBackColor = false;
            this.btn_adminStandards.Click += new System.EventHandler(this.btn_adminStandars_Click);
            // 
            // cbo_Standars
            // 
            this.cbo_Standars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_Standars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Standars.Font = new System.Drawing.Font("Lemon/Milk", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Standars.FormattingEnabled = true;
            this.cbo_Standars.Location = new System.Drawing.Point(6, 16);
            this.cbo_Standars.Name = "cbo_Standars";
            this.cbo_Standars.Size = new System.Drawing.Size(145, 23);
            this.cbo_Standars.TabIndex = 18;
            this.cbo_Standars.SelectedIndexChanged += new System.EventHandler(this.cbo_Standars_SelectedIndexChanged);
            // 
            // txt_DecisionProblem
            // 
            this.txt_DecisionProblem.Location = new System.Drawing.Point(15, 68);
            this.txt_DecisionProblem.Name = "txt_DecisionProblem";
            this.txt_DecisionProblem.Size = new System.Drawing.Size(223, 20);
            this.txt_DecisionProblem.TabIndex = 17;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(15, 91);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(52, 23);
            this.lbl_Date.TabIndex = 18;
            this.lbl_Date.Text = "Fecha:";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ProblemDate
            // 
            this.txt_ProblemDate.Enabled = false;
            this.txt_ProblemDate.Location = new System.Drawing.Point(73, 94);
            this.txt_ProblemDate.Name = "txt_ProblemDate";
            this.txt_ProblemDate.Size = new System.Drawing.Size(68, 20);
            this.txt_ProblemDate.TabIndex = 19;
            // 
            // lbl_ProblemImportant
            // 
            this.lbl_ProblemImportant.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProblemImportant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ProblemImportant.Location = new System.Drawing.Point(10, 30);
            this.lbl_ProblemImportant.Name = "lbl_ProblemImportant";
            this.lbl_ProblemImportant.Size = new System.Drawing.Size(240, 35);
            this.lbl_ProblemImportant.TabIndex = 20;
            this.lbl_ProblemImportant.Text = "Problema de Decisión";
            this.lbl_ProblemImportant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ProblemImportant.UseMnemonic = false;
            // 
            // lbl_StandardMax
            // 
            this.lbl_StandardMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StandardMax.Location = new System.Drawing.Point(117, 160);
            this.lbl_StandardMax.Name = "lbl_StandardMax";
            this.lbl_StandardMax.Size = new System.Drawing.Size(73, 23);
            this.lbl_StandardMax.TabIndex = 18;
            this.lbl_StandardMax.Text = "( máx. 7 )";
            this.lbl_StandardMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(62, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 39);
            this.label1.TabIndex = 23;
            this.label1.Text = "ATRÁS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbox_backArrow
            // 
            this.pbox_backArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_backArrow.Location = new System.Drawing.Point(12, 432);
            this.pbox_backArrow.Name = "pbox_backArrow";
            this.pbox_backArrow.Size = new System.Drawing.Size(50, 29);
            this.pbox_backArrow.TabIndex = 22;
            this.pbox_backArrow.TabStop = false;
            this.pbox_backArrow.Click += new System.EventHandler(this.pbox_backArrow_Click);
            // 
            // pbox_interrogation
            // 
            this.pbox_interrogation.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbox_interrogation.InitialImage")));
            this.pbox_interrogation.Location = new System.Drawing.Point(336, 20);
            this.pbox_interrogation.Name = "pbox_interrogation";
            this.pbox_interrogation.Size = new System.Drawing.Size(160, 161);
            this.pbox_interrogation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_interrogation.TabIndex = 21;
            this.pbox_interrogation.TabStop = false;
            // 
            // btn_generateAlternatives
            // 
            this.btn_generateAlternatives.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_generateAlternatives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generateAlternatives.Enabled = false;
            this.btn_generateAlternatives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generateAlternatives.Location = new System.Drawing.Point(211, 429);
            this.btn_generateAlternatives.Name = "btn_generateAlternatives";
            this.btn_generateAlternatives.Size = new System.Drawing.Size(285, 32);
            this.btn_generateAlternatives.TabIndex = 24;
            this.btn_generateAlternatives.Text = "Cargar Alternativas";
            this.btn_generateAlternatives.UseVisualStyleBackColor = false;
            // 
            // Decision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 463);
            this.Controls.Add(this.btn_generateAlternatives);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbox_backArrow);
            this.Controls.Add(this.pbox_interrogation);
            this.Controls.Add(this.lbl_StandardMax);
            this.Controls.Add(this.lbl_ProblemImportant);
            this.Controls.Add(this.txt_ProblemDate);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.txt_DecisionProblem);
            this.Controls.Add(this.gbox_Standards);
            this.Controls.Add(this.lbl_Standards);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Decision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Decisión - Optimal Decision";
            this.Load += new System.EventHandler(this.Decision_Load);
            this.gbox_Standards.ResumeLayout(false);
            this.gbox_Standards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_standards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_backArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_interrogation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_StandardDescription;
        private System.Windows.Forms.Label lbl_Standards;
        private System.Windows.Forms.Button btn_addStandard;
        private System.Windows.Forms.GroupBox gbox_Standards;
        private System.Windows.Forms.TextBox txt_DecisionProblem;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox txt_ProblemDate;
        private System.Windows.Forms.Label lbl_ProblemImportant;
        private System.Windows.Forms.Label lbl_StandardMax;
        private System.Windows.Forms.PictureBox pbox_interrogation;
        private System.Windows.Forms.Button btn_adminStandards;
        private System.Windows.Forms.ComboBox cbo_Standars;
        private System.Windows.Forms.PictureBox pbox_backArrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_value;
        private System.Windows.Forms.DataGridView dgv_standards;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdStandard;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_generateAlternatives;
    }
}