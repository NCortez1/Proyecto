namespace GestionBasica.GUI
{
    partial class EdicionLector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionLector));
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDLector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCambiarContraseña = new System.Windows.Forms.CheckBox();
            this.txtConfirmarCredencial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCredencial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaxPrestamo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaxTiempo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCredibilidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbAvanzado = new System.Windows.Forms.CheckBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxFoto
            // 
            this.pbxFoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbxFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxFoto.Image")));
            this.pbxFoto.Location = new System.Drawing.Point(287, 25);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(135, 169);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFoto.TabIndex = 26;
            this.pbxFoto.TabStop = false;
            this.pbxFoto.Click += new System.EventHandler(this.pbxFoto_Click);
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO"});
            this.cmbGenero.Location = new System.Drawing.Point(89, 326);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 25;
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "yyyy/MM/dd";
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(89, 280);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(115, 20);
            this.dtFecha.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha de \r\nNacimiento";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(89, 163);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(151, 20);
            this.txtApellidos.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Apellidos";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(89, 121);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(151, 20);
            this.txtNombres.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombres";
            // 
            // txtIDLector
            // 
            this.txtIDLector.Location = new System.Drawing.Point(91, 37);
            this.txtIDLector.Name = "txtIDLector";
            this.txtIDLector.ReadOnly = true;
            this.txtIDLector.Size = new System.Drawing.Size(57, 20);
            this.txtIDLector.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "IDLector";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(194, 380);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(287, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(89, 80);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(151, 20);
            this.txtUsuario.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Usuario";
            // 
            // cbCambiarContraseña
            // 
            this.cbCambiarContraseña.AutoSize = true;
            this.cbCambiarContraseña.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbCambiarContraseña.Location = new System.Drawing.Point(119, 191);
            this.cbCambiarContraseña.Name = "cbCambiarContraseña";
            this.cbCambiarContraseña.Size = new System.Drawing.Size(121, 17);
            this.cbCambiarContraseña.TabIndex = 33;
            this.cbCambiarContraseña.Text = "Cambiar Contraseña";
            this.cbCambiarContraseña.UseVisualStyleBackColor = true;
            this.cbCambiarContraseña.CheckedChanged += new System.EventHandler(this.cbCambiarContraseña_CheckedChanged);
            // 
            // txtConfirmarCredencial
            // 
            this.txtConfirmarCredencial.Location = new System.Drawing.Point(89, 236);
            this.txtConfirmarCredencial.Name = "txtConfirmarCredencial";
            this.txtConfirmarCredencial.PasswordChar = '*';
            this.txtConfirmarCredencial.Size = new System.Drawing.Size(151, 20);
            this.txtConfirmarCredencial.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 26);
            this.label7.TabIndex = 31;
            this.label7.Text = "Confirmar\r\nContraseña";
            // 
            // txtCredencial
            // 
            this.txtCredencial.Location = new System.Drawing.Point(89, 210);
            this.txtCredencial.Name = "txtCredencial";
            this.txtCredencial.PasswordChar = '*';
            this.txtCredencial.Size = new System.Drawing.Size(151, 20);
            this.txtCredencial.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Contraseña";
            // 
            // txtMaxPrestamo
            // 
            this.txtMaxPrestamo.Location = new System.Drawing.Point(287, 245);
            this.txtMaxPrestamo.Name = "txtMaxPrestamo";
            this.txtMaxPrestamo.Size = new System.Drawing.Size(135, 20);
            this.txtMaxPrestamo.TabIndex = 35;
            this.txtMaxPrestamo.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Max. Prestamo";
            this.label9.Visible = false;
            // 
            // txtMaxTiempo
            // 
            this.txtMaxTiempo.Location = new System.Drawing.Point(287, 285);
            this.txtMaxTiempo.Name = "txtMaxTiempo";
            this.txtMaxTiempo.Size = new System.Drawing.Size(135, 20);
            this.txtMaxTiempo.TabIndex = 37;
            this.txtMaxTiempo.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Max. Tiempo Prestamo";
            this.label10.Visible = false;
            // 
            // txtCredibilidad
            // 
            this.txtCredibilidad.Location = new System.Drawing.Point(287, 328);
            this.txtCredibilidad.Name = "txtCredibilidad";
            this.txtCredibilidad.Size = new System.Drawing.Size(135, 20);
            this.txtCredibilidad.TabIndex = 39;
            this.txtCredibilidad.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Credibilidad";
            this.label11.Visible = false;
            // 
            // cbAvanzado
            // 
            this.cbAvanzado.AutoSize = true;
            this.cbAvanzado.Location = new System.Drawing.Point(289, 203);
            this.cbAvanzado.Name = "cbAvanzado";
            this.cbAvanzado.Size = new System.Drawing.Size(127, 17);
            this.cbAvanzado.TabIndex = 40;
            this.cbAvanzado.Text = "Opciones Avanzadas";
            this.cbAvanzado.UseVisualStyleBackColor = true;
            this.cbAvanzado.CheckedChanged += new System.EventHandler(this.cbAvanzado_CheckedChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "yyyy/MM/dd";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(33, 379);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(115, 20);
            this.dtpFechaInicio.TabIndex = 41;
            // 
            // EdicionLector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 420);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cbAvanzado);
            this.Controls.Add(this.txtCredibilidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMaxTiempo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMaxPrestamo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbCambiarContraseña);
            this.Controls.Add(this.txtConfirmarCredencial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCredencial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDLector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "EdicionLector";
            this.Text = "EdicionLector";
            this.Load += new System.EventHandler(this.EdicionLector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbxFoto;
        public System.Windows.Forms.ComboBox cmbGenero;
        public System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtIDLector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbCambiarContraseña;
        public System.Windows.Forms.TextBox txtConfirmarCredencial;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtCredencial;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtMaxPrestamo;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtMaxTiempo;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtCredibilidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbAvanzado;
        public System.Windows.Forms.DateTimePicker dtpFechaInicio;
    }
}