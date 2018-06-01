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
    public partial class EdicionCategoria : Form
    {
        public EdicionCategoria()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CLS.Categorias oCategoria = new CLS.Categorias();
            oCategoria.IDCategoria = txtIDCategoria.Text;
            oCategoria.Categoria = txtCategoria.Text;
            if (txtIDCategoria.TextLength > 0)
            {
                if (oCategoria.Actualzar())
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
                if (oCategoria.Insertar())
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
            if (txtCategoria.TextLength > 0)
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            ValidarNoNulo();
        }
    }
}
