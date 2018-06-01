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
    public partial class EdicionLector : Form
    {
        public EdicionLector(bool actualizar = false)
        {
            InitializeComponent();
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

        private void cbAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAvanzado.Checked)
            {
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                txtMaxPrestamo.Visible = true;
                txtMaxTiempo.Visible = true;
                txtCredibilidad.Visible = true;
            }else
            {
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                txtMaxPrestamo.Visible = false;
                txtMaxTiempo.Visible = false;
                txtCredibilidad.Visible = false;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CLS.Lectores oLector = new CLS.Lectores();
            oLector.IDLector = txtIDLector.Text;
            oLector.Usuario = txtUsuario.Text;
            oLector.Credencial = txtCredencial.Text;
            oLector.Nombres = txtNombres.Text;
            oLector.Apellidos = txtApellidos.Text;
            oLector.FechaNacimiento = dtFecha.Text;
            oLector.Genero = cmbGenero.SelectedItem.ToString();
            oLector.Fecha_inicio = dtpFechaInicio.Text;
            oLector.MaxPrestamo = txtMaxPrestamo.Text;
            oLector.MaxTiempoPrestamo = txtMaxTiempo.Text;
            oLector.Credibilidad = txtCredibilidad.Text;
            oLector.Foto = pbxFoto.Image;

            if (txtIDLector.TextLength > 0)
            {
                if (txtCredencial.Text.Equals(txtConfirmarCredencial.Text) && cbCambiarContraseña.Checked)
                {
                    //ACTUALIZAR CON CREDENCIAL
                    if (oLector.Actualzar(true))
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
                    if (oLector.Actualzar())
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
                    if (oLector.Insertar())
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

        private void pbxFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivo JPG|*.jpg";

            if (file.ShowDialog() == DialogResult.OK)
            {
                pbxFoto.Image = Image.FromFile(file.FileName);
            }
        }

        private void EdicionLector_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.Visible = false;
        }
    }
}
