namespace GestionBasica.GUI
{
    partial class EdicionLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionLibro));
            this.pbxPortada = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDLibro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContenidos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbEditoriales = new System.Windows.Forms.ComboBox();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.cmbAutores = new System.Windows.Forms.ComboBox();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPortada
            // 
            this.pbxPortada.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbxPortada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPortada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPortada.Image = ((System.Drawing.Image)(resources.GetObject("pbxPortada.Image")));
            this.pbxPortada.Location = new System.Drawing.Point(327, 24);
            this.pbxPortada.Name = "pbxPortada";
            this.pbxPortada.Size = new System.Drawing.Size(151, 169);
            this.pbxPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPortada.TabIndex = 26;
            this.pbxPortada.TabStop = false;
            this.pbxPortada.Click += new System.EventHandler(this.pbxPortada_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Categoria";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(99, 68);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(151, 20);
            this.txtTitulo.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Titulo";
            // 
            // txtIDLibro
            // 
            this.txtIDLibro.Location = new System.Drawing.Point(99, 24);
            this.txtIDLibro.Name = "txtIDLibro";
            this.txtIDLibro.ReadOnly = true;
            this.txtIDLibro.Size = new System.Drawing.Size(57, 20);
            this.txtIDLibro.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(327, 363);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(420, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Autor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Editorial";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(99, 322);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(151, 20);
            this.txtPaginas.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Paginas";
            // 
            // txtContenidos
            // 
            this.txtContenidos.Location = new System.Drawing.Point(304, 241);
            this.txtContenidos.Multiline = true;
            this.txtContenidos.Name = "txtContenidos";
            this.txtContenidos.Size = new System.Drawing.Size(191, 101);
            this.txtContenidos.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(305, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Contenidos";
            // 
            // cmbEditoriales
            // 
            this.cmbEditoriales.FormattingEnabled = true;
            this.cmbEditoriales.Location = new System.Drawing.Point(99, 238);
            this.cmbEditoriales.Name = "cmbEditoriales";
            this.cmbEditoriales.Size = new System.Drawing.Size(151, 21);
            this.cmbEditoriales.TabIndex = 44;
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(99, 279);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(151, 21);
            this.cmbCategorias.TabIndex = 45;
            // 
            // cmbAutores
            // 
            this.cmbAutores.FormattingEnabled = true;
            this.cmbAutores.Location = new System.Drawing.Point(99, 193);
            this.cmbAutores.Name = "cmbAutores";
            this.cmbAutores.Size = new System.Drawing.Size(151, 21);
            this.cmbAutores.TabIndex = 46;
            // 
            // txtEdicion
            // 
            this.txtEdicion.Location = new System.Drawing.Point(99, 110);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(151, 20);
            this.txtEdicion.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Edicion";
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "yyyy/MM/dd";
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(99, 150);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(115, 20);
            this.dtFecha.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 51;
            this.label4.Text = "Fecha de \r\nLanzamiento";
            // 
            // EdicionLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 406);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEdicion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbAutores);
            this.Controls.Add(this.cmbCategorias);
            this.Controls.Add(this.cmbEditoriales);
            this.Controls.Add(this.txtContenidos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbxPortada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDLibro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "EdicionLibro";
            this.Text = "EdicionLibro";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbxPortada;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtIDLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtContenidos;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmbEditoriales;
        public System.Windows.Forms.ComboBox cmbCategorias;
        public System.Windows.Forms.ComboBox cmbAutores;
        public System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label4;
    }
}