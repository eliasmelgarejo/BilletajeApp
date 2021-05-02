namespace BilletajeApp.vistas
{
    partial class w_Post
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroTarjeta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMessage4 = new System.Windows.Forms.TextBox();
            this.txtMessage3 = new System.Windows.Forms.TextBox();
            this.txtMessage2 = new System.Windows.Forms.TextBox();
            this.txtMessage1 = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.cboBuses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroBus = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aproxime Tarjeta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNroTarjeta
            // 
            this.txtNroTarjeta.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNroTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroTarjeta.Location = new System.Drawing.Point(27, 152);
            this.txtNroTarjeta.Name = "txtNroTarjeta";
            this.txtNroTarjeta.Size = new System.Drawing.Size(372, 38);
            this.txtNroTarjeta.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtMessage4);
            this.panel1.Controls.Add(this.txtMessage3);
            this.panel1.Controls.Add(this.txtMessage2);
            this.panel1.Controls.Add(this.txtMessage1);
            this.panel1.Location = new System.Drawing.Point(27, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 330);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(132, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtMessage4
            // 
            this.txtMessage4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMessage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage4.Location = new System.Drawing.Point(21, 240);
            this.txtMessage4.Name = "txtMessage4";
            this.txtMessage4.ReadOnly = true;
            this.txtMessage4.Size = new System.Drawing.Size(351, 38);
            this.txtMessage4.TabIndex = 3;
            // 
            // txtMessage3
            // 
            this.txtMessage3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMessage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage3.Location = new System.Drawing.Point(21, 196);
            this.txtMessage3.Name = "txtMessage3";
            this.txtMessage3.ReadOnly = true;
            this.txtMessage3.Size = new System.Drawing.Size(351, 38);
            this.txtMessage3.TabIndex = 2;
            // 
            // txtMessage2
            // 
            this.txtMessage2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMessage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage2.Location = new System.Drawing.Point(21, 152);
            this.txtMessage2.Name = "txtMessage2";
            this.txtMessage2.ReadOnly = true;
            this.txtMessage2.Size = new System.Drawing.Size(351, 38);
            this.txtMessage2.TabIndex = 1;
            // 
            // txtMessage1
            // 
            this.txtMessage1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMessage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage1.Location = new System.Drawing.Point(21, 108);
            this.txtMessage1.Name = "txtMessage1";
            this.txtMessage1.ReadOnly = true;
            this.txtMessage1.Size = new System.Drawing.Size(351, 38);
            this.txtMessage1.TabIndex = 0;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Image = global::BilletajeApp.Properties.Resources.process_24;
            this.btnProcesar.Location = new System.Drawing.Point(405, 147);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(50, 48);
            this.btnProcesar.TabIndex = 3;
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // cboBuses
            // 
            this.cboBuses.BackColor = System.Drawing.SystemColors.Menu;
            this.cboBuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuses.FormattingEnabled = true;
            this.cboBuses.Location = new System.Drawing.Point(12, 37);
            this.cboBuses.Name = "cboBuses";
            this.cboBuses.Size = new System.Drawing.Size(282, 28);
            this.cboBuses.TabIndex = 4;
            this.cboBuses.SelectedIndexChanged += new System.EventHandler(this.cboBuses_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Elija Bus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Coche #";
            // 
            // txtNroBus
            // 
            this.txtNroBus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNroBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroBus.ForeColor = System.Drawing.Color.DarkRed;
            this.txtNroBus.Location = new System.Drawing.Point(299, 37);
            this.txtNroBus.Name = "txtNroBus";
            this.txtNroBus.ReadOnly = true;
            this.txtNroBus.Size = new System.Drawing.Size(156, 26);
            this.txtNroBus.TabIndex = 7;
            this.txtNroBus.Text = "**";
            this.txtNroBus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // w_Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(467, 555);
            this.Controls.Add(this.txtNroBus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboBuses);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNroTarjeta);
            this.Controls.Add(this.label1);
            this.Name = "w_Post";
            this.Text = "w_Post";
            this.Load += new System.EventHandler(this.w_Post_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroTarjeta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMessage4;
        private System.Windows.Forms.TextBox txtMessage3;
        private System.Windows.Forms.TextBox txtMessage2;
        private System.Windows.Forms.TextBox txtMessage1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ComboBox cboBuses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroBus;
    }
}