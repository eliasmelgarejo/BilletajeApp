namespace BilletajeApp.vistas
{
    partial class MDIHOME
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.maestrosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestros_empBilletajeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaciones_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestros_usuariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maestrosMenuItem,
            this.operaciones_MenuItem,
            this.ayudaMenuItem,
            this.salirMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(595, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip2";
            // 
            // maestrosMenuItem
            // 
            this.maestrosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maestros_empBilletajeMenuItem,
            this.maestros_usuariosMenuItem});
            this.maestrosMenuItem.Name = "maestrosMenuItem";
            this.maestrosMenuItem.Size = new System.Drawing.Size(67, 20);
            this.maestrosMenuItem.Text = "Maestros";
            // 
            // maestros_empBilletajeMenuItem
            // 
            this.maestros_empBilletajeMenuItem.Name = "maestros_empBilletajeMenuItem";
            this.maestros_empBilletajeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maestros_empBilletajeMenuItem.Text = "Emp. Billetaje";
            this.maestros_empBilletajeMenuItem.Click += new System.EventHandler(this.maestros_empBilletajeMenuItem_Click);
            // 
            // operaciones_MenuItem
            // 
            this.operaciones_MenuItem.Name = "operaciones_MenuItem";
            this.operaciones_MenuItem.Size = new System.Drawing.Size(85, 20);
            this.operaciones_MenuItem.Text = "Operaciones";
            // 
            // ayudaMenuItem
            // 
            this.ayudaMenuItem.Name = "ayudaMenuItem";
            this.ayudaMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaMenuItem.Text = "Ayuda";
            // 
            // salirMenuItem
            // 
            this.salirMenuItem.Name = "salirMenuItem";
            this.salirMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirMenuItem.Text = "Salir";
            this.salirMenuItem.Click += new System.EventHandler(this.salirMenuItem_Click);
            // 
            // maestros_usuariosMenuItem
            // 
            this.maestros_usuariosMenuItem.Name = "maestros_usuariosMenuItem";
            this.maestros_usuariosMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maestros_usuariosMenuItem.Text = "Usuarios";
            this.maestros_usuariosMenuItem.Click += new System.EventHandler(this.maestros_usuariosMenuItem_Click);
            // 
            // MDIHOME
            // 
            this.ClientSize = new System.Drawing.Size(595, 470);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "MDIHOME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Mant_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mant_EmpBilletaje_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Salir_MenuItem;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem maestrosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestros_empBilletajeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operaciones_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestros_usuariosMenuItem;
    }
}