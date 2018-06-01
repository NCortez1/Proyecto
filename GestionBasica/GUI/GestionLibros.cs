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
    public partial class GestionLibros : Form
    {
        BindingSource _LIBROS = new BindingSource();
        public bool Seleccionar = false;
        public String IDLib;
        public String Lib;
        public GestionLibros(bool select = false)
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
        private void CargarDatos()
        {
            _LIBROS.DataSource = CacheController.Cache.TODOS_LOS_LIBROS();
            dtgRegistros.DataSource = _LIBROS;
            lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
        }

        private void GestionLibros_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void FiltrarLocalmente()
        {
            try
            {
                if (txtFiltro.TextLength > 0)
                {
                    _LIBROS.Filter = "Titulo LIKE '%" + txtFiltro.Text + "%'";
                }
                else
                {
                    _LIBROS.RemoveFilter();
                }
                dtgRegistros.AutoGenerateColumns = false;
                dtgRegistros.DataSource = _LIBROS;
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
            EdicionLibro frm = new EdicionLibro();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EdicionLibro frm = new EdicionLibro();

            frm.txtIDLibro.Text = dtgRegistros.CurrentRow.Cells["IDLibro"].Value.ToString();
            frm.txtTitulo.Text = dtgRegistros.CurrentRow.Cells["Titulo"].Value.ToString();
            frm.cmbAutores.SelectedItem = dtgRegistros.CurrentRow.Cells["IDAutor"].Value.ToString();
            frm.cmbEditoriales.SelectedItem = dtgRegistros.CurrentRow.Cells["IDEditorial"].Value.ToString();
            frm.cmbCategorias.SelectedItem = dtgRegistros.CurrentRow.Cells["IDCategoria"].Value.ToString();
            frm.txtEdicion.Text = dtgRegistros.CurrentRow.Cells["Edicion"].Value.ToString();
            frm.txtContenidos.Text = dtgRegistros.CurrentRow.Cells["Contenidos"].Value.ToString();
            frm.dtFecha.Text = dtgRegistros.CurrentRow.Cells["Fecha_Lanzamiento"].Value.ToString();
            frm.txtPaginas.Text = dtgRegistros.CurrentRow.Cells["Paginas"].Value.ToString();

            DataGridViewRow row = dtgRegistros.CurrentRow;
            DataRowView rows = row.DataBoundItem as DataRowView;
            frm.pbxPortada.Image = Functions.Class1.ByteArrayToImage((byte[])rows["Portada"]);
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Libros oLibro = new CLS.Libros();
                oLibro.IDLibro = dtgRegistros.CurrentRow.Cells["IDLibro"].Value.ToString();
                if (oLibro.Eliminar())
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar = true;
            IDLib = dtgRegistros.CurrentRow.Cells["IDLibro"].Value.ToString();
            Lib = dtgRegistros.CurrentRow.Cells["TItulo"].Value.ToString();
            Close();
        }
    }
}
