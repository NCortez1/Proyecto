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
    public partial class EdicionEditorial : Form
    {
        public EdicionEditorial()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CLS.Editoriales oEditorial = new CLS.Editoriales();
            oEditorial.IDEditorial = txtIDEditorial.Text;
            oEditorial.Nombre = txtEditorial.Text;
            oEditorial.Direccion = txtDireccion.Text;
            oEditorial.Telefono = txtTelefono.Text;
            if (txtIDEditorial.TextLength > 0)
            {
                if (oEditorial.Actualzar())
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
                if (oEditorial.Insertar())
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
    }
}
