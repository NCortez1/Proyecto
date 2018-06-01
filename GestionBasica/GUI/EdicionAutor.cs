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
    public partial class EdicionAutor : Form
    {
        public EdicionAutor()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CLS.Autores oAutor = new CLS.Autores();
            oAutor.IDAutor = txtIDAutor.Text;
            oAutor.Nombre = txtAutor.Text;
            oAutor.Fecha_Nacimiento = dtFecha.Text;
            oAutor.Residencia = txtResidencia.Text;
            if (txtIDAutor.TextLength > 0)
            {
                if (oAutor.Actualzar())
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
                if (oAutor.Insertar())
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

        //------------------------- Validaciones ---------------------------
        private void ValidarNoNulo()
        {
            if ((txtAutor.TextLength > 0) && (txtResidencia.TextLength > 0))
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {
            ValidarNoNulo();
        }

        private void txtResidencia_TextChanged(object sender, EventArgs e)
        {
            ValidarNoNulo();
        }
    }
}
