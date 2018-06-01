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
    public partial class EdicionEjemplar : Form
    {
        public EdicionEjemplar()
        {
            InitializeComponent();
        }

        private void CargarEstados()
        {
            DataTable Estados = new DataTable();
            Estados = CacheController.Cache.TODOS_LOS_ESTADOS();
            cmbEstados.DataSource = Estados;
            cmbEstados.DisplayMember = "Estado";
            cmbEstados.ValueMember = "IDEstado";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CLS.Ejemplares oEjemplar = new CLS.Ejemplares();
            oEjemplar.IDEjemplar = txtIDEjemplar.Text;
            oEjemplar.IDLibro = txtIDLibro.Text;
            oEjemplar.N_Ejemplar = txtNEjemplar.Text;
            oEjemplar.Ubicacion = txtUbicacion.Text;
            oEjemplar.Fecha_Ingreso = dtgFechaIngreso.Text;
            if (cbFecha.Checked)
            {
                oEjemplar.Fecha_Salida = dtgFechaSalida.Text;
            }else
            {
                oEjemplar.Fecha_Salida = null;
            }
            oEjemplar.Estado_Libro = txtEstado.Text;
            oEjemplar.IDEstado = cmbEstados.SelectedValue.ToString();

            if (txtIDEjemplar.TextLength > 0)
            {
                if (oEjemplar.Actualzar())
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
                if (oEjemplar.Insertar())
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

        private void EdicionEjemplar_Load(object sender, EventArgs e)
        {
            CargarEstados();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            GestionLibros frm = new GestionLibros(true);
            frm.ShowDialog();

            if (frm.Seleccionar)
            {
                txtIDLibro.Text = frm.IDLib;
                txtTitulo.Text = frm.Lib;
            }
        }

        public void FechaSalida(String fechaS)
        {
            if (fechaS != "")
            {
                dtgFechaSalida.Text = fechaS;
                cbFecha.Checked = true;
                dtgFechaSalida.Enabled = true;
            } else
            {
                cbFecha.Checked = false;
            }
        }
        private void cbFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFecha.Checked)
            {
                dtgFechaSalida.Enabled = true;
            }else
            {
                dtgFechaSalida.Enabled = false;
            }
        }
    }
}
