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
    public partial class GestionEjemplares : Form
    {
        BindingSource _EJEMPLARES = new BindingSource();
        public GestionEjemplares()
        {
            InitializeComponent();
        }

        private void GestionEjemplares_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            _EJEMPLARES.DataSource = CacheController.Cache.TODOS_LOS_EJEMPLARES();
            dtgRegistros.DataSource = _EJEMPLARES;
            lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
        }
        private void FiltrarLocalmente()
        {
            try
            {
                if (txtFiltro.TextLength > 0)
                {
                    _EJEMPLARES.Filter = "Titulo LIKE '%" + txtFiltro.Text + "%'";
                }
                else
                {
                    _EJEMPLARES.RemoveFilter();
                }
                dtgRegistros.AutoGenerateColumns = false;
                dtgRegistros.DataSource = _EJEMPLARES;
                lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
            }
            catch
            { }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionEjemplar frm = new EdicionEjemplar();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EdicionEjemplar frm = new EdicionEjemplar();

            frm.txtIDEjemplar.Text = dtgRegistros.CurrentRow.Cells["IDEjemplar"].Value.ToString();
            frm.txtIDLibro.Text = dtgRegistros.CurrentRow.Cells["IDLibro"].Value.ToString();
            frm.txtTitulo.Text = dtgRegistros.CurrentRow.Cells["Titulo"].Value.ToString();
            frm.txtNEjemplar.Text = dtgRegistros.CurrentRow.Cells["N_Ejemplar"].Value.ToString();
            frm.txtUbicacion.Text = dtgRegistros.CurrentRow.Cells["Ubicacion"].Value.ToString();
            frm.cmbEstados.SelectedValue = dtgRegistros.CurrentRow.Cells["Estado"].Value.ToString();
            frm.dtgFechaIngreso.Text = dtgRegistros.CurrentRow.Cells["Fecha_Ingreso"].Value.ToString();
            frm.FechaSalida(dtgRegistros.CurrentRow.Cells["Fecha_Salida"].Value.ToString());
            frm.txtEstado.Text = dtgRegistros.CurrentRow.Cells["Estado_Libro"].Value.ToString();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Ejemplares oEjemplar = new CLS.Ejemplares();
                oEjemplar.IDEjemplar = dtgRegistros.CurrentRow.Cells["IDEjemplar"].Value.ToString();
                if (oEjemplar.Eliminar())
                {
                    MessageBox.Show("Eliminado");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("Falló la eliminación");
                }
            }
        }
    }
}
