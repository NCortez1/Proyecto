using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.GUI
{
    public partial class EdicionUsuario : Form
    {
        public EdicionUsuario(bool actualizar=false)
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
            CargarRoles();
            if (actualizar)
            {
                cbCambiarContraseña.Visible = true;
                txtCredencial.ReadOnly = true;
                txtConfirmarCredencial.ReadOnly = true;
            }
            else
            {
                cbCambiarContraseña.Visible = false;
            }
        }

        private void CargarRoles()
        {
            DataTable Roles = new DataTable();
            Roles = CacheController.Cache.TODOS_LOS_ROLES();
            cmbRoles.DataSource = Roles;
            cmbRoles.DisplayMember = "Rol";
            cmbRoles.ValueMember = "IDRol";
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            GestionEmpleados frm = new GestionEmpleados(true);
            DialogResult res = frm.ShowDialog();
            
            if (frm.Seleccionar)
            {
                txtIDEmpleado.Text = frm.IDEmp;
                txtEmpleado.Text = frm.Emp;
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CLS.Usuarios oUsuario = new CLS.Usuarios();
            oUsuario.IDUsuario = txtIDUsuario.Text;
            oUsuario.Usuario = txtUsuario.Text;
            oUsuario.Credencial = txtCredencial.Text;
            oUsuario.IDEmpleado = txtIDEmpleado.Text;
            oUsuario.IDRol = cmbRoles.SelectedValue.ToString();
            if (txtIDUsuario.TextLength > 0)
            {
                if (txtCredencial.Text.Equals(txtConfirmarCredencial.Text) && cbCambiarContraseña.Checked)
                {
                    //ACTUALIZAR CON CREDENCIAL
                    if (oUsuario.Actualizar(true))
                    {
                        MessageBox.Show("Actualizado");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Falló la Actualización");
                    }
                }
                else
                {
                    //ACTUALIZAR SIN CREDENCIAL
                    if (oUsuario.Actualizar())
                    {
                        MessageBox.Show("Actualizado");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Falló la Actualización");
                    }
                }
            }
            else
            {
                if (txtCredencial.Text.Equals(txtConfirmarCredencial.Text))
                {
                    //INSERTAR
                    if (oUsuario.Insertar())
                    {
                        MessageBox.Show("Insertado");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Falló la Inserción");
                    }
                }
                else
                {
                    MessageBox.Show("Las Contraseñas no Coinciden");
                }
                
            }
        }

        private void cbCambiarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCambiarContraseña.Checked)
            {
                txtCredencial.ReadOnly = false;
                txtConfirmarCredencial.ReadOnly = false;
            }
            else
            {
                txtCredencial.ReadOnly = true;
                txtConfirmarCredencial.ReadOnly = true;
            }
        }


        //==================  validar campos nulos ==============
        private void ValidarNoNulo()
        {
            if ((txtUsuario.TextLength > 0) && (txtCredencial.TextLength > 0) && (txtIDEmpleado.TextLength > 0))
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            ValidarNoNulo();
        }

        private void txtCredencial_TextChanged(object sender, EventArgs e)
        {
            ValidarNoNulo();
        }

        private void txtIDEmpleado_TextChanged(object sender, EventArgs e)
        {
            ValidarNoNulo();
        }


    }
}
