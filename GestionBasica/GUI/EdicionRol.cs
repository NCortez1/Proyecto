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
    public partial class EdicionRol : Form
    {
        public EdicionRol()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CLS.Roles oRol = new CLS.Roles();
            oRol.IDRol = txtIDRol.Text;
            oRol.NombreRol = txtRol.Text;
            if (txtIDRol.TextLength > 0)
            {
                if (oRol.Actualzar())
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
                if (oRol.Insertar())
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

        //------------------------- Validaciones ---------------------------
        private void ValidarNoNulo()
        {
            if (txtRol.TextLength > 0){
                btnGuardar.Enabled = true;
            }else{
                btnGuardar.Enabled = false;
            }
        }


        private void txtRol_TextChanged(object sender, EventArgs e)
        {
            ValidarNoNulo();
        }


        //----------------------- solo letras --------------------------------
        private void txtRol_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }else
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }  
        }
    }
}
