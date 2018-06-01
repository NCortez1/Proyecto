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
    public partial class EdicionEmpleado : Form
    {
        
        public EdicionEmpleado()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
            //--- Seleccion de combobox ---
            if (txtIDEmpleado.TextLength == 0)
            {
                cmbGenero.SelectedIndex = 0;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CLS.Empleados oEmpleado = new CLS.Empleados();
            oEmpleado.IDEmpleado = txtIDEmpleado.Text;
            oEmpleado.Nombres = txtNombres.Text;
            oEmpleado.Apellidos = txtApellidos.Text;
            oEmpleado.FechaNacimiento = dtFecha.Text;
            oEmpleado.Genero = cmbGenero.SelectedItem.ToString();
            oEmpleado.Foto = pbxFoto.Image;

            if (txtIDEmpleado.TextLength > 0)
            {
                if (oEmpleado.Actualzar())
                {
                    MessageBox.Show("Actualizado");
                    Close();
                }
                else
                {
                    MessageBox.Show("Falló la Actualizacion");
                }
            }
            else
            {
                if (oEmpleado.Insertar())
                {
                    MessageBox.Show("Insertado");
                    Close();
                }
                else
                {
                    MessageBox.Show("Falló la Insercion");
                }
            }
               
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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

        //------------------------- Validaciones ---------------------------
        private void ValidarNoNulo()
        {
            if ((txtNombres.TextLength > 0) && (txtApellidos.TextLength > 0))
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            ValidarNoNulo();
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            ValidarNoNulo();
        }


        //----------------------- solo letras -----------------------------
        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((Char.IsLetter(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((Char.IsLetter(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
    }
}
