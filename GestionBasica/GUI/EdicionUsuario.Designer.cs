namespace GestionBasica.GUI
{
    partial class EdicionUsuario
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
            System.Windows.Forms.Button btnEmpleado;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionUsuario));
            this.Cancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.txtCredencial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConfirmarCredencial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCambiarContraseña = new System.Windows.Forms.CheckBox();
            btnEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpleado
            // 
            btnEmpleado.BackColor = System.Drawing.Color.Transparent;
            btnEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmpleado.BackgroundImage")));
            btnEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnEmpleado.ForeColor = System.Drawing.Color.Transparent;
            btnEmpleado.Location = new System.Drawing.Point(252, 178);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new System.Drawing.Size(29, 26);
            btnEmpleado.TabIndex = 12;
            btnEmpleado.UseVisualStyleBackColor = false;
            btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(239, 317);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 0;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(148, 317);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IDUsuario";
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(106, 21);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.ReadOnly = true;
            this.txtIDUsuario.Size = new System.Drawing.Size(64, 20);
            this.txtIDUsuario.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(106, 65);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(175, 20);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Location = new System.Drawing.Point(106, 182);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.ReadOnly = true;
            this.txtIDEmpleado.Size = new System.Drawing.Size(64, 20);
            this.txtIDEmpleado.TabIndex = 7;
            this.txtIDEmpleado.TextChanged += new System.EventHandler(this.txtIDEmpleado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "IDEmpleado";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(106, 210);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.ReadOnly = true;
            this.txtEmpleado.Size = new System.Drawing.Size(175, 20);
            this.txtEmpleado.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rol";
            // 
            // cmbRoles
            // 
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(106, 254);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(175, 21);
            this.cmbRoles.TabIndex = 1;
            // 
            // txtCredencial
            // 
            this.txtCredencial.Location = new System.Drawing.Point(106, 112);
            this.txtCredencial.Name = "txtCredencial";
            this.txtCredencial.PasswordChar = '*';
            this.txtCredencial.Size = new System.Drawing.Size(175, 20);
            this.txtCredencial.TabIndex = 14;
            this.txtCredencial.TextChanged += new System.EventHandler(this.txtCredencial_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contraseña";
            // 
            // txtConfirmarCredencial
            // 
            this.txtConfirmarCredencial.Location = new System.Drawing.Point(106, 138);
            this.txtConfirmarCredencial.Name = "txtConfirmarCredencial";
            this.txtConfirmarCredencial.PasswordChar = '*';
            this.txtConfirmarCredencial.Size = new System.Drawing.Size(175, 20);
            this.txtConfirmarCredencial.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Confirmar\r\nContraseña";
            // 
            // cbCambiarContraseña
            // 
            this.cbCambiarContraseña.AutoSize = true;
            this.cbCambiarContraseña.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbCambiarContraseña.Location = new System.Drawing.Point(160, 93);
            this.cbCambiarContraseña.Name = "cbCambiarContraseña";
            this.cbCambiarContraseña.Size = new System.Drawing.Size(121, 17);
            this.cbCambiarContraseña.TabIndex = 17;
            this.cbCambiarContraseña.Text = "Cambiar Contraseña";
            this.cbCambiarContraseña.UseVisualStyleBackColor = true;
            this.cbCambiarContraseña.CheckedChanged += new System.EventHandler(this.cbCambiarContraseña_CheckedChanged);
            // 
            // EdicionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 361);
            this.Controls.Add(this.cbCambiarContraseña);
            this.Controls.Add(this.txtConfirmarCredencial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCredencial);
            this.Controls.Add(this.label6);
            this.Controls.Add(btnEmpleado);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.Cancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EdicionUsuario";
            this.Text = "Edición de Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbCambiarContraseña;
        public System.Windows.Forms.TextBox txtIDUsuario;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtEmpleado;
        public System.Windows.Forms.ComboBox cmbRoles;
        public System.Windows.Forms.TextBox txtCredencial;
        public System.Windows.Forms.TextBox txtConfirmarCredencial;
    }
}