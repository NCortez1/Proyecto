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
    public partial class GestionCategorias : Form
    {
        BindingSource _CATEGORIAS = new BindingSource();
        public bool Seleccionar = false;
        public String IDCat;
        public String Cat;
        private void CargarDatos()
        {
            _CATEGORIAS.DataSource = CacheController.Cache.TODAS_LAS_CATEGORIAS();
            dtgRegistros.DataSource = _CATEGORIAS;
            lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
        }
        private void FiltrarLocalmente()
        {
            try
            {
                if (txtFiltro.TextLength > 0)
                {
                    _CATEGORIAS.Filter = "Categoria LIKE '%" + txtFiltro.Text + "%'";
                }
                else
                {
                    _CATEGORIAS.RemoveFilter();
                }
                dtgRegistros.AutoGenerateColumns = false;
                dtgRegistros.DataSource = _CATEGORIAS;
                lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
            }
            catch
            { }
        }
        public GestionCategorias(bool select = false)
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

        private void GestionCategorias_Load(object sender, EventArgs e)
        {
            CargarDatos();
            alternarColores(dtgRegistros);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionCategoria frm = new EdicionCategoria();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EdicionCategoria frm = new EdicionCategoria();
            frm.txtIDCategoria.Text = dtgRegistros.CurrentRow.Cells["IDCategoria"].Value.ToString();
            frm.txtCategoria.Text = dtgRegistros.CurrentRow.Cells["Categoria"].Value.ToString();
            frm.txtEstandares.Text = dtgRegistros.CurrentRow.Cells["Estandares"].Value.ToString();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Categorias oCategoria = new CLS.Categorias();
                oCategoria.IDCategoria = dtgRegistros.CurrentRow.Cells["IDCategoria"].Value.ToString();
                if (oCategoria.Eliminar())
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
            IDCat = dtgRegistros.CurrentRow.Cells["IDCategoria"].Value.ToString();
            Cat = dtgRegistros.CurrentRow.Cells["Categoria"].Value.ToString();
            Close();
        }

        //------------------ Color de filas datagridview ------------
        private void alternarColores(DataGridView dtg)
        {
            dtg.RowsDefaultCellStyle.BackColor = Color.DarkGray;
            dtg.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }
    }
}
