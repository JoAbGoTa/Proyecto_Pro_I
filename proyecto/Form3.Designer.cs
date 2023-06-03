namespace proyecto
{
    partial class Form3
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtcarnet = new System.Windows.Forms.TextBox();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbus = new System.Windows.Forms.TextBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNUEV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(61, 455);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 34);
            this.btnGuardar.TabIndex = 58;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(57, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 24);
            this.label3.TabIndex = 57;
            this.label3.Text = "FECHA DE NACIMIENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(57, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = "DIRECCION";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(57, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "CARNÉ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.Location = new System.Drawing.Point(57, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 24);
            this.label10.TabIndex = 54;
            this.label10.Text = "NOMBRE";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtfecha.Location = new System.Drawing.Point(61, 360);
            this.txtfecha.Multiline = true;
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(273, 22);
            this.txtfecha.TabIndex = 53;
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtdireccion.Location = new System.Drawing.Point(61, 265);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(273, 22);
            this.txtdireccion.TabIndex = 52;
            // 
            // txtcarnet
            // 
            this.txtcarnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtcarnet.Location = new System.Drawing.Point(61, 183);
            this.txtcarnet.Name = "txtcarnet";
            this.txtcarnet.Size = new System.Drawing.Size(273, 22);
            this.txtcarnet.TabIndex = 51;
            // 
            // txtNombre1
            // 
            this.txtNombre1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtNombre1.Location = new System.Drawing.Point(61, 108);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(273, 22);
            this.txtNombre1.TabIndex = 50;
            this.txtNombre1.TextChanged += new System.EventHandler(this.txtNombre1_TextChanged);
            // 
            // textCodigo
            // 
            this.textCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.textCodigo.Enabled = false;
            this.textCodigo.Location = new System.Drawing.Point(60, 37);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(142, 22);
            this.textCodigo.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(58, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 60;
            this.label4.Text = "CODIGO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(746, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 24);
            this.label5.TabIndex = 65;
            this.label5.Text = "BUSCAR POR NOMBRE";
            // 
            // txtbus
            // 
            this.txtbus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.txtbus.Location = new System.Drawing.Point(585, 80);
            this.txtbus.Multiline = true;
            this.txtbus.Name = "txtbus";
            this.txtbus.Size = new System.Drawing.Size(467, 34);
            this.txtbus.TabIndex = 64;
            this.txtbus.TextChanged += new System.EventHandler(this.txtbus_TextChanged);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.btneditar.ForeColor = System.Drawing.Color.Black;
            this.btneditar.Location = new System.Drawing.Point(750, 481);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(112, 34);
            this.btneditar.TabIndex = 63;
            this.btneditar.Text = "EDITAR";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnborrar.ForeColor = System.Drawing.Color.Black;
            this.btnborrar.Location = new System.Drawing.Point(1020, 481);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(112, 34);
            this.btnborrar.TabIndex = 62;
            this.btnborrar.Text = "BORRAR";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(455, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(713, 321);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnNUEV
            // 
            this.btnNUEV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.btnNUEV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNUEV.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNUEV.ForeColor = System.Drawing.Color.Black;
            this.btnNUEV.Location = new System.Drawing.Point(496, 481);
            this.btnNUEV.Name = "btnNUEV";
            this.btnNUEV.Size = new System.Drawing.Size(112, 34);
            this.btnNUEV.TabIndex = 66;
            this.btnNUEV.Text = "NUEVO";
            this.btnNUEV.UseVisualStyleBackColor = false;
            this.btnNUEV.Click += new System.EventHandler(this.btnNUEV_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1209, 588);
            this.Controls.Add(this.btnNUEV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbus);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtcarnet);
            this.Controls.Add(this.txtNombre1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtcarnet;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbus;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNUEV;
    }
}