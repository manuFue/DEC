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
            this.Next = new System.Windows.Forms.Button();
            this.txt_Counter = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_donation = new System.Windows.Forms.TextBox();
            this.lbl_donation = new System.Windows.Forms.Label();
            this.lbl_windows = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(598, 140);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(97, 35);
            this.Next.TabIndex = 0;
            this.Next.Text = "To Another Window!";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // txt_Counter
            // 
            this.txt_Counter.Location = new System.Drawing.Point(424, 166);
            this.txt_Counter.Name = "txt_Counter";
            this.txt_Counter.Size = new System.Drawing.Size(100, 20);
            this.txt_Counter.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donarToolStripMenuItem,
            this.cerrarXToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.inicioToolStripMenuItem.Text = "Menu";
            // 
            // donarToolStripMenuItem
            // 
            this.donarToolStripMenuItem.Name = "donarToolStripMenuItem";
            this.donarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.donarToolStripMenuItem.Text = "Donate [ $ ]";
            this.donarToolStripMenuItem.Click += new System.EventHandler(this.donarToolStripMenuItem_Click);
            // 
            // cerrarXToolStripMenuItem
            // 
            this.cerrarXToolStripMenuItem.Name = "cerrarXToolStripMenuItem";
            this.cerrarXToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.cerrarXToolStripMenuItem.Text = "Close [ X ]";
            this.cerrarXToolStripMenuItem.Click += new System.EventHandler(this.cerrarXToolStripMenuItem_Click);
            // 
            // txt_donation
            // 
            this.txt_donation.Location = new System.Drawing.Point(424, 129);
            this.txt_donation.Name = "txt_donation";
            this.txt_donation.Size = new System.Drawing.Size(100, 20);
            this.txt_donation.TabIndex = 3;
            // 
            // lbl_donation
            // 
            this.lbl_donation.AutoSize = true;
            this.lbl_donation.Location = new System.Drawing.Point(442, 113);
            this.lbl_donation.Name = "lbl_donation";
            this.lbl_donation.Size = new System.Drawing.Size(64, 13);
            this.lbl_donation.TabIndex = 4;
            this.lbl_donation.Text = "DONATION";
            // 
            // lbl_windows
            // 
            this.lbl_windows.AutoSize = true;
            this.lbl_windows.Location = new System.Drawing.Point(442, 189);
            this.lbl_windows.Name = "lbl_windows";
            this.lbl_windows.Size = new System.Drawing.Size(76, 13);
            this.lbl_windows.TabIndex = 5;
            this.lbl_windows.Text = "New Windows";
            // 
            // PrincipalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lbl_windows);
            this.Controls.Add(this.lbl_donation);
            this.Controls.Add(this.txt_donation);
            this.Controls.Add(this.txt_Counter);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimal Decision";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox txt_Counter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarXToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_donation;
        private System.Windows.Forms.Label lbl_donation;
        private System.Windows.Forms.Label lbl_windows;
    }
}

