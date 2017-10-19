namespace Window
{
    partial class PrincipalWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaDecisiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criteriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarCriteriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightSalmon;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.criteriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(587, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaDecisiónToolStripMenuItem,
            this.cerrarXToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(50, 26);
            this.inicioToolStripMenuItem.Text = "Menu";
            // 
            // nuevaDecisiónToolStripMenuItem
            // 
            this.nuevaDecisiónToolStripMenuItem.Name = "nuevaDecisiónToolStripMenuItem";
            this.nuevaDecisiónToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.nuevaDecisiónToolStripMenuItem.Text = "Nueva Decisión";
            this.nuevaDecisiónToolStripMenuItem.Click += new System.EventHandler(this.nuevaDecisiónToolStripMenuItem_Click);
            // 
            // cerrarXToolStripMenuItem
            // 
            this.cerrarXToolStripMenuItem.Name = "cerrarXToolStripMenuItem";
            this.cerrarXToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cerrarXToolStripMenuItem.Text = "Close [ X ]";
            this.cerrarXToolStripMenuItem.Click += new System.EventHandler(this.cerrarXToolStripMenuItem_Click);
            // 
            // criteriosToolStripMenuItem
            // 
            this.criteriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarCriteriosToolStripMenuItem});
            this.criteriosToolStripMenuItem.Name = "criteriosToolStripMenuItem";
            this.criteriosToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.criteriosToolStripMenuItem.Text = "Criterios";
            // 
            // administrarCriteriosToolStripMenuItem
            // 
            this.administrarCriteriosToolStripMenuItem.Name = "administrarCriteriosToolStripMenuItem";
            this.administrarCriteriosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.administrarCriteriosToolStripMenuItem.Text = "Administrar Criterios";
            this.administrarCriteriosToolStripMenuItem.Click += new System.EventHandler(this.administrarCriteriosToolStripMenuItem_Click);
            // 
            // PrincipalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.embossing_003fn_gallery_large;
            this.ClientSize = new System.Drawing.Size(587, 370);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "PrincipalWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimal Decision";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaDecisiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criteriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarCriteriosToolStripMenuItem;
    }
}

