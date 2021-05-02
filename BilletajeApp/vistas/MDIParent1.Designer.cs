namespace BilletajeApp.vistas
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.maestrosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestros_empBilletajeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestros_usuariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaciones_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PostMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maestrosMenuItem,
            this.operaciones_MenuItem,
            this.ayudaMenuItem,
            this.salirMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(632, 24);
            this.menu.TabIndex = 4;
            this.menu.Text = "menuStrip2";
            // 
            // maestrosMenuItem
            // 
            this.maestrosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maestros_empBilletajeMenuItem,
            this.maestros_usuariosMenuItem,
            this.busMenuItem});
            this.maestrosMenuItem.Name = "maestrosMenuItem";
            this.maestrosMenuItem.Size = new System.Drawing.Size(67, 20);
            this.maestrosMenuItem.Text = "Maestros";
            // 
            // maestros_empBilletajeMenuItem
            // 
            this.maestros_empBilletajeMenuItem.Name = "maestros_empBilletajeMenuItem";
            this.maestros_empBilletajeMenuItem.Size = new System.Drawing.Size(145, 22);
            this.maestros_empBilletajeMenuItem.Text = "Emp. Billetaje";
            this.maestros_empBilletajeMenuItem.Click += new System.EventHandler(this.maestros_empBilletajeMenuItem_Click);
            // 
            // maestros_usuariosMenuItem
            // 
            this.maestros_usuariosMenuItem.Name = "maestros_usuariosMenuItem";
            this.maestros_usuariosMenuItem.Size = new System.Drawing.Size(145, 22);
            this.maestros_usuariosMenuItem.Text = "Usuarios";
            this.maestros_usuariosMenuItem.Click += new System.EventHandler(this.maestros_usuariosMenuItem_Click);
            // 
            // busMenuItem
            // 
            this.busMenuItem.Name = "busMenuItem";
            this.busMenuItem.Size = new System.Drawing.Size(145, 22);
            this.busMenuItem.Text = "Bus";
            this.busMenuItem.Click += new System.EventHandler(this.busMenuItem_Click);
            // 
            // operaciones_MenuItem
            // 
            this.operaciones_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PostMenuItem,
            this.tarjetasMenuItem});
            this.operaciones_MenuItem.Name = "operaciones_MenuItem";
            this.operaciones_MenuItem.Size = new System.Drawing.Size(85, 20);
            this.operaciones_MenuItem.Text = "Operaciones";
            // 
            // PostMenuItem
            // 
            this.PostMenuItem.Name = "PostMenuItem";
            this.PostMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PostMenuItem.Text = "POST";
            this.PostMenuItem.Click += new System.EventHandler(this.PostMenuItem_Click);
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
            // tarjetasMenuItem
            // 
            this.tarjetasMenuItem.Name = "tarjetasMenuItem";
            this.tarjetasMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tarjetasMenuItem.Text = "Tarjetas";
            this.tarjetasMenuItem.Click += new System.EventHandler(this.tarjetasMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem maestrosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestros_empBilletajeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestros_usuariosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operaciones_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem PostMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarjetasMenuItem;
    }
}



