namespace Pantalla
{
    partial class PantallaPrincipal
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
            this.Next = new System.Windows.Forms.Button();
            this.txtBox_Contador = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_donacion = new System.Windows.Forms.TextBox();
            this.lbl_donacion = new System.Windows.Forms.Label();
            this.lbl_ventanas = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(26, 37);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(97, 35);
            this.Next.TabIndex = 0;
            this.Next.Text = "A otra ventana!";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // txtBox_Contador
            // 
            this.txtBox_Contador.Location = new System.Drawing.Point(83, 156);
            this.txtBox_Contador.Name = "txtBox_Contador";
            this.txtBox_Contador.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Contador.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donarToolStripMenuItem,
            this.cerrarXToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // donarToolStripMenuItem
            // 
            this.donarToolStripMenuItem.Name = "donarToolStripMenuItem";
            this.donarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.donarToolStripMenuItem.Text = "Donar [ $ ]";
            this.donarToolStripMenuItem.Click += new System.EventHandler(this.donarToolStripMenuItem_Click);
            // 
            // cerrarXToolStripMenuItem
            // 
            this.cerrarXToolStripMenuItem.Name = "cerrarXToolStripMenuItem";
            this.cerrarXToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarXToolStripMenuItem.Text = "Cerrar [ X ]";
            this.cerrarXToolStripMenuItem.Click += new System.EventHandler(this.cerrarXToolStripMenuItem_Click);
            // 
            // txt_donacion
            // 
            this.txt_donacion.Location = new System.Drawing.Point(83, 119);
            this.txt_donacion.Name = "txt_donacion";
            this.txt_donacion.Size = new System.Drawing.Size(100, 20);
            this.txt_donacion.TabIndex = 3;
            // 
            // lbl_donacion
            // 
            this.lbl_donacion.AutoSize = true;
            this.lbl_donacion.Location = new System.Drawing.Point(101, 103);
            this.lbl_donacion.Name = "lbl_donacion";
            this.lbl_donacion.Size = new System.Drawing.Size(64, 13);
            this.lbl_donacion.TabIndex = 4;
            this.lbl_donacion.Text = "DONACIÓN";
            // 
            // lbl_ventanas
            // 
            this.lbl_ventanas.AutoSize = true;
            this.lbl_ventanas.Location = new System.Drawing.Point(80, 179);
            this.lbl_ventanas.Name = "lbl_ventanas";
            this.lbl_ventanas.Size = new System.Drawing.Size(92, 13);
            this.lbl_ventanas.TabIndex = 5;
            this.lbl_ventanas.Text = "Nuevas Ventanas";
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_ventanas);
            this.Controls.Add(this.lbl_donacion);
            this.Controls.Add(this.txt_donacion);
            this.Controls.Add(this.txtBox_Contador);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox txtBox_Contador;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarXToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_donacion;
        private System.Windows.Forms.Label lbl_donacion;
        private System.Windows.Forms.Label lbl_ventanas;
    }
}

