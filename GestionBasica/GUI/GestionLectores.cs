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
    public partial class GestionLectores : Form
    {
        BindingSource _LECTORES = new BindingSource();
        public bool Seleccionar = false;
        public String IDLect;
        public String Lect;
        public GestionLectores(bool select = false)
        {
            InitializeComponent();

            if (select)
            {
                btnSeleccionar.Visible = true;
            }
            else
            {
                btnSeleccionar.Visible = false;
            }
        }

        private void GestionLectores_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            _LECTORES.DataSource = CacheController.Cache.TODOS_LOS_LECTORES();
            dtgRegistros.DataSource = _LECTORES;
            foreach (DataGridViewRow row in dtgRegistros.Rows)
            {
                row.Height = 100;
                DataRowView rows = row.DataBoundItem as DataRowView;
                row.Cells["Foto"].Value = Functions.Class1.ByteArrayToImage((byte[])rows["Foto"]);
            }
            lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
        }
        private void FiltrarLocalmente()
        {
            try
            {
                if (txtFiltro.TextLength > 0)
                {
                    _LECTORES.Filter = "Apellidos LIKE '%" + txtFiltro.Text + "%'";
                }
                else
                {
                    _LECTORES.RemoveFilter();
                }
                dtgRegistros.AutoGenerateColumns = false;
                dtgRegistros.DataSource = _LECTORES;
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
            EdicionLector frm = new EdicionLector();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar = true;
            IDLect = dtgRegistros.CurrentRow.Cells["IDLector"].Value.ToString();
            Lect = dtgRegistros.CurrentRow.Cells["Nombres"].Value.ToString() + " " + dtgRegistros.CurrentRow.Cells["Apellidos"].Value.ToString(); ;
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EdicionLector frm = new EdicionLector(true);
            frm.txtIDLector.Text = dtgRegistros.CurrentRow.Cells["IDLector"].Value.ToString();
            frm.txtUsuario.Text = dtgRegistros.CurrentRow.Cells["Usuario"].Value.ToString();
            frm.txtNombres.Text = dtgRegistros.CurrentRow.Cells["Nombres"].Value.ToString();
            frm.txtApellidos.Text = dtgRegistros.CurrentRow.Cells["Apellidos"].Value.ToString();
            frm.dtFecha.Text = dtgRegistros.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
            frm.cmbGenero.SelectedItem = dtgRegistros.CurrentRow.Cells["Genero"].Value.ToString();
            frm.dtpFechaInicio.Text = dtgRegistros.CurrentRow.Cells["Fecha_Inicio"].Value.ToString();
            frm.txtMaxPrestamo.Text = dtgRegistros.CurrentRow.Cells["MaxPrestamo"].Value.ToString();
            frm.txtMaxTiempo.Text = dtgRegistros.CurrentRow.Cells["MaxTiempoPrestamo"].Value.ToString();
            frm.txtCredibilidad.Text= dtgRegistros.CurrentRow.Cells["Credibilidad"].Value.ToString();

            DataGridViewRow row = dtgRegistros.CurrentRow;
            DataRowView rows = row.DataBoundItem as DataRowView;
            frm.pbxFoto.Image = Functions.Class1.ByteArrayToImage((byte[])rows["Foto"]);
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Lectores oLector = new CLS.Lectores();
                oLector.IDLector = dtgRegistros.CurrentRow.Cells["IDLector"].Value.ToString();
                if (oLector.Eliminar())
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
