namespace GestionBasica.GUI
{
    partial class EdicionEjemplar
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
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDLibro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDEjemplar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.btnLibro = new System.Windows.Forms.Button();
            this.txtNEjemplar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFecha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbEstados
            // 
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Location = new System.Drawing.Point(122, 208);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(175, 21);
            this.cmbEstados.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Estado";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(122, 93);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(175, 20);
            this.txtTitulo.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Titulo";
            // 
            // txtIDLibro
            // 
            this.txtIDLibro.Location = new System.Drawing.Point(122, 65);
            this.txtIDLibro.Name = "txtIDLibro";
            this.txtIDLibro.ReadOnly = true;
            this.txtIDLibro.Size = new System.Drawing.Size(64, 20);
            this.txtIDLibro.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "IDLibro";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(122, 170);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(175, 20);
            this.txtUbicacion.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ubicacion";
            // 
            // txtIDEjemplar
            // 
            this.txtIDEjemplar.Location = new System.Drawing.Point(122, 23);
            this.txtIDEjemplar.Name = "txtIDEjemplar";
            this.txtIDEjemplar.ReadOnly = true;
            this.txtIDEjemplar.Size = new System.Drawing.Size(64, 20);
            this.txtIDEjemplar.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(169, 377);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(74, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(260, 377);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(74, 23);
            this.Cancelar.TabIndex = 18;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // btnLibro
            // 
            this.btnLibro.Location = new System.Drawing.Point(268, 62);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(29, 23);
            this.btnLibro.TabIndex = 30;
            this.btnLibro.Text = "...";
            this.btnLibro.UseVisualStyleBackColor = true;
            this.btnLibro.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // txtNEjemplar
            // 
            this.txtNEjemplar.Location = new System.Drawing.Point(122, 132);
            this.txtNEjemplar.Name = "txtNEjemplar";
            this.txtNEjemplar.Size = new System.Drawing.Size(175, 20);
            this.txtNEjemplar.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "# Ejemplar";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(122, 331);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(175, 20);
            this.txtEstado.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Estado del Libro";
            // 
            // dtgFechaIngreso
            // 
            this.dtgFechaIngreso.CustomFormat = "yyyy/MM/dd";
            this.dtgFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtgFechaIngreso.Location = new System.Drawing.Point(122, 250);
            this.dtgFechaIngreso.Name = "dtgFechaIngreso";
            this.dtgFechaIngreso.Size = new System.Drawing.Size(175, 20);
            this.dtgFechaIngreso.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 26);
            this.label8.TabIndex = 35;
            this.label8.Text = "Fecha de \r\nIngreso";
            // 
            // dtgFechaSalida
            // 
            this.dtgFechaSalida.CustomFormat = "yyyy/MM/dd";
            this.dtgFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtgFechaSalida.Location = new System.Drawing.Point(122, 290);
            this.dtgFechaSalida.Name = "dtgFechaSalida";
            this.dtgFechaSalida.Size = new System.Drawing.Size(148, 20);
            this.dtgFechaSalida.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 26);
            this.label9.TabIndex = 37;
            this.label9.Text = "Fecha de \r\nSalida";
            // 
            // cbFecha
            // 
            this.cbFecha.AutoSize = true;
            this.cbFecha.Location = new System.Drawing.Point(282, 293);
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.Size = new System.Drawing.Size(15, 14);
            this.cbFecha.TabIndex = 39;
            this.cbFecha.UseVisualStyleBackColor = true;
            this.cbFecha.CheckedChanged += new System.EventHandler(this.cbFecha_CheckedChanged);
            // 
            // EdicionEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 422);
            this.Controls.Add(this.cbFecha);
            this.Controls.Add(this.dtgFechaSalida);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtgFechaIngreso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNEjemplar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLibro);
            this.Controls.Add(this.cmbEstados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDLibro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDEjemplar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.Cancelar);
            this.Name = "EdicionEjemplar";
            this.Text = "EdicionEjemplar";
            this.Load += new System.EventHandler(this.EdicionEjemplar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtIDLibro;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtIDEjemplar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button btnLibro;
        public System.Windows.Forms.TextBox txtNEjemplar;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker dtgFechaIngreso;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker dtgFechaSalida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbFecha;
    }
}