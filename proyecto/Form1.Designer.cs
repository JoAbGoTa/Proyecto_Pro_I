namespace proyecto
{
    partial class pacont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pacont));
            this.titulo = new System.Windows.Forms.Panel();
            this.btnmax = new System.Windows.Forms.PictureBox();
            this.btnmaxx = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnregistro = new System.Windows.Forms.Button();
            this.panelcont = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaxx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.menu.SuspendLayout();
            this.panelcont.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(82)))));
            this.titulo.Controls.Add(this.btnmax);
            this.titulo.Controls.Add(this.btnmaxx);
            this.titulo.Controls.Add(this.btnminimizar);
            this.titulo.Controls.Add(this.btncerrar);
            this.titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(1476, 35);
            this.titulo.TabIndex = 26;
            this.titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.titulo_Paint);
            this.titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmax.Image = global::proyecto.Properties.Resources.maxi;
            this.btnmax.Location = new System.Drawing.Point(1404, 5);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(25, 25);
            this.btnmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmax.TabIndex = 3;
            this.btnmax.TabStop = false;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // btnmaxx
            // 
            this.btnmaxx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaxx.Image = global::proyecto.Properties.Resources.res;
            this.btnmaxx.Location = new System.Drawing.Point(1405, 5);
            this.btnmaxx.Name = "btnmaxx";
            this.btnmaxx.Size = new System.Drawing.Size(25, 25);
            this.btnmaxx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaxx.TabIndex = 2;
            this.btnmaxx.TabStop = false;
            this.btnmaxx.Visible = false;
            this.btnmaxx.Click += new System.EventHandler(this.btnmaxx_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(1369, 5);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(25, 25);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 1;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(1439, 5);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(25, 25);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 0;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.menu.Controls.Add(this.panel1);
            this.menu.Controls.Add(this.btnregistro);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 35);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(230, 587);
            this.menu.TabIndex = 30;
            this.menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcont_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(12, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 32);
            this.panel1.TabIndex = 57;
            // 
            // btnregistro
            // 
            this.btnregistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btnregistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistro.FlatAppearance.BorderSize = 0;
            this.btnregistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistro.Font = new System.Drawing.Font("MoeumT R", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnregistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnregistro.Image = global::proyecto.Properties.Resources.producto;
            this.btnregistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistro.Location = new System.Drawing.Point(6, 196);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(227, 32);
            this.btnregistro.TabIndex = 1;
            this.btnregistro.Text = "REGISTRAR";
            this.btnregistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnregistro.UseVisualStyleBackColor = false;
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // panelcont
            // 
            this.panelcont.BackColor = System.Drawing.Color.SlateGray;
            this.panelcont.Controls.Add(this.panel2);
            this.panelcont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcont.Location = new System.Drawing.Point(230, 35);
            this.panelcont.Name = "panelcont";
            this.panelcont.Size = new System.Drawing.Size(1246, 587);
            this.panelcont.TabIndex = 31;
            this.panelcont.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcont_Paint_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(60, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 486);
            this.panel2.TabIndex = 57;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_2);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::proyecto.Properties.Resources.a_gif;
            this.pictureBox4.Location = new System.Drawing.Point(260, 170);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(574, 266);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 60;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::proyecto.Properties.Resources.asdq;
            this.pictureBox3.Location = new System.Drawing.Point(58, 132);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(958, 10);
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::proyecto.Properties.Resources.asdq;
            this.pictureBox2.Location = new System.Drawing.Point(79, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(958, 10);
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyecto.Properties.Resources.asdq;
            this.pictureBox1.Location = new System.Drawing.Point(58, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(958, 10);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(191, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(717, 67);
            this.label1.TabIndex = 56;
            this.label1.Text = "BIENVENIDO AL REGISTRO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pacont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1476, 622);
            this.Controls.Add(this.panelcont);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pacont";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaxx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.menu.ResumeLayout(false);
            this.panelcont.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel titulo;
        private System.Windows.Forms.PictureBox btnmaxx;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnmax;
        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel panelcont;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

