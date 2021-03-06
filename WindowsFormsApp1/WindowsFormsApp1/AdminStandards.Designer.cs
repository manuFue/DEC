﻿using System.Windows.Forms;

namespace Aplication
{
    partial class AdminStandards
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStandards));
            this.btn_ready = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.gbox_new = new System.Windows.Forms.GroupBox();
            this.btn_modify = new System.Windows.Forms.Button();
            this.panel_radiobuttons = new System.Windows.Forms.Panel();
            this.radiob_min = new System.Windows.Forms.RadioButton();
            this.radiob_max = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_standards = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbox_list = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.gbox_new.SuspendLayout();
            this.panel_radiobuttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_standards)).BeginInit();
            this.gbox_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ready
            // 
            this.btn_ready.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_ready.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ready.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ready.Location = new System.Drawing.Point(486, 444);
            this.btn_ready.Name = "btn_ready";
            this.btn_ready.Size = new System.Drawing.Size(118, 26);
            this.btn_ready.TabIndex = 35;
            this.btn_ready.Text = "Listo";
            this.btn_ready.UseVisualStyleBackColor = false;
            this.btn_ready.Click += new System.EventHandler(this.btn_ready_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_Name.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(121, 21);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(264, 24);
            this.txt_Name.TabIndex = 31;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(13, 18);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(77, 23);
            this.lbl_Name.TabIndex = 32;
            this.lbl_Name.Text = "Nombre :";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Description
            // 
            this.txt_Description.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Description.Location = new System.Drawing.Point(121, 49);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(264, 48);
            this.txt_Description.TabIndex = 30;
            // 
            // lbl_description
            // 
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(13, 47);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(102, 23);
            this.lbl_description.TabIndex = 33;
            this.lbl_description.Text = "Descripción :";
            this.lbl_description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_addNew
            // 
            this.btn_addNew.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_addNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNew.Location = new System.Drawing.Point(452, 20);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(118, 29);
            this.btn_addNew.TabIndex = 34;
            this.btn_addNew.Text = "Agregar Nuevo";
            this.btn_addNew.UseVisualStyleBackColor = false;
            this.btn_addNew.Click += new System.EventHandler(this.btn_addNew_Click);
            // 
            // gbox_new
            // 
            this.gbox_new.BackColor = System.Drawing.Color.Transparent;
            this.gbox_new.Controls.Add(this.btn_modify);
            this.gbox_new.Controls.Add(this.panel_radiobuttons);
            this.gbox_new.Controls.Add(this.label2);
            this.gbox_new.Controls.Add(this.txt_Name);
            this.gbox_new.Controls.Add(this.lbl_Name);
            this.gbox_new.Controls.Add(this.txt_Description);
            this.gbox_new.Controls.Add(this.lbl_description);
            this.gbox_new.Controls.Add(this.btn_addNew);
            this.gbox_new.Location = new System.Drawing.Point(34, 59);
            this.gbox_new.Name = "gbox_new";
            this.gbox_new.Size = new System.Drawing.Size(584, 129);
            this.gbox_new.TabIndex = 36;
            this.gbox_new.TabStop = false;
            this.gbox_new.Text = "Criterio";
            // 
            // btn_modify
            // 
            this.btn_modify.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_modify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modify.Enabled = false;
            this.btn_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modify.Location = new System.Drawing.Point(452, 89);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(118, 29);
            this.btn_modify.TabIndex = 40;
            this.btn_modify.Text = "Modificar";
            this.btn_modify.UseVisualStyleBackColor = false;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // panel_radiobuttons
            // 
            this.panel_radiobuttons.Controls.Add(this.radiob_min);
            this.panel_radiobuttons.Controls.Add(this.radiob_max);
            this.panel_radiobuttons.Location = new System.Drawing.Point(121, 95);
            this.panel_radiobuttons.Name = "panel_radiobuttons";
            this.panel_radiobuttons.Size = new System.Drawing.Size(264, 32);
            this.panel_radiobuttons.TabIndex = 39;
            // 
            // radiob_min
            // 
            this.radiob_min.AutoSize = true;
            this.radiob_min.Location = new System.Drawing.Point(165, 6);
            this.radiob_min.Name = "radiob_min";
            this.radiob_min.Size = new System.Drawing.Size(96, 17);
            this.radiob_min.TabIndex = 36;
            this.radiob_min.Text = "MINIMIZANTE";
            this.radiob_min.UseVisualStyleBackColor = true;
            this.radiob_min.CheckedChanged += new System.EventHandler(this.radiob_min_CheckedChanged);
            // 
            // radiob_max
            // 
            this.radiob_max.AutoSize = true;
            this.radiob_max.Checked = true;
            this.radiob_max.Location = new System.Drawing.Point(3, 6);
            this.radiob_max.Name = "radiob_max";
            this.radiob_max.Size = new System.Drawing.Size(99, 17);
            this.radiob_max.TabIndex = 35;
            this.radiob_max.TabStop = true;
            this.radiob_max.Text = "MAXIMIZANTE";
            this.radiob_max.UseVisualStyleBackColor = true;
            this.radiob_max.CheckedChanged += new System.EventHandler(this.radiob_max_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 37);
            this.label2.TabIndex = 37;
            this.label2.Text = "Optimización :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_standards
            // 
            this.dgv_standards.AllowUserToAddRows = false;
            this.dgv_standards.AllowUserToDeleteRows = false;
            this.dgv_standards.AllowUserToResizeColumns = false;
            this.dgv_standards.AllowUserToResizeRows = false;
            this.dgv_standards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_standards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.description,
            this.optimization});
            this.dgv_standards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_standards.Location = new System.Drawing.Point(16, 81);
            this.dgv_standards.MultiSelect = false;
            this.dgv_standards.Name = "dgv_standards";
            this.dgv_standards.ReadOnly = true;
            this.dgv_standards.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_standards.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_standards.Size = new System.Drawing.Size(554, 156);
            this.dgv_standards.TabIndex = 37;
            this.dgv_standards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Standards_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.name.DefaultCellStyle = dataGridViewCellStyle1;
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // description
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.description.DefaultCellStyle = dataGridViewCellStyle2;
            this.description.HeaderText = "Descripción";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 275;
            // 
            // optimization
            // 
            this.optimization.HeaderText = "Optimización";
            this.optimization.Name = "optimization";
            this.optimization.ReadOnly = true;
            // 
            // gbox_list
            // 
            this.gbox_list.BackColor = System.Drawing.Color.Transparent;
            this.gbox_list.Controls.Add(this.label1);
            this.gbox_list.Controls.Add(this.txt_search);
            this.gbox_list.Controls.Add(this.btn_delete);
            this.gbox_list.Controls.Add(this.dgv_standards);
            this.gbox_list.Location = new System.Drawing.Point(34, 194);
            this.gbox_list.Name = "gbox_list";
            this.gbox_list.Size = new System.Drawing.Size(584, 244);
            this.gbox_list.TabIndex = 38;
            this.gbox_list.TabStop = false;
            this.gbox_list.Text = "Lista de Criterios";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "< Buscar Criterio >";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(16, 55);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(211, 20);
            this.txt_search.TabIndex = 39;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DarkGray;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Enabled = false;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(452, 50);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(118, 29);
            this.btn_delete.TabIndex = 35;
            this.btn_delete.Text = "Eliminar Criterio";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_admin
            // 
            this.lbl_admin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.Location = new System.Drawing.Point(147, 9);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(387, 47);
            this.lbl_admin.TabIndex = 35;
            this.lbl_admin.Text = "Administrar Criterios";
            this.lbl_admin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Clean
            // 
            this.btn_Clean.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_Clean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clean.Location = new System.Drawing.Point(540, 27);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(64, 29);
            this.btn_Clean.TabIndex = 41;
            this.btn_Clean.Text = "Limpiar";
            this.btn_Clean.UseVisualStyleBackColor = false;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // AdminStandards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Back2;
            this.ClientSize = new System.Drawing.Size(671, 474);
            this.Controls.Add(this.btn_Clean);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.gbox_list);
            this.Controls.Add(this.gbox_new);
            this.Controls.Add(this.btn_ready);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminStandards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimal Decision";
            this.Load += new System.EventHandler(this.adminStandards_Load);
            this.gbox_new.ResumeLayout(false);
            this.gbox_new.PerformLayout();
            this.panel_radiobuttons.ResumeLayout(false);
            this.panel_radiobuttons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_standards)).EndInit();
            this.gbox_list.ResumeLayout(false);
            this.gbox_list.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ready;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Button btn_addNew;
        private System.Windows.Forms.GroupBox gbox_new;
        private System.Windows.Forms.DataGridView dgv_standards;
        private System.Windows.Forms.GroupBox gbox_list;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.RadioButton radiob_min;
        private System.Windows.Forms.RadioButton radiob_max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_radiobuttons;
        private Button btn_modify;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn optimization;
        private Button btn_Clean;
    }
}