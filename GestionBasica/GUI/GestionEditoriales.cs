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
    public partial class GestionEditoriales : Form
    {
        BindingSource _EDITORIALES = new BindingSource();
        public bool Seleccionar = false;
        public String IDEdit;
        public String Nomb;
        private void CargarDatos()
        {
            _EDITORIALES.DataSource = CacheController.Cache.TODAS_LAS_EDITORIALES();
            dtgRegistros.DataSource = _EDITORIALES;
            lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
        }
        private void FiltrarLocalmente()
        {
            try
            {
                if (txtFiltro.TextLength > 0)
                {
                    _EDITORIALES.Filter = "Nombre LIKE '%" + txtFiltro.Text + "%'";
                }
                else
                {
                    _EDITORIALES.RemoveFilter();
                }
                dtgRegistros.AutoGenerateColumns = false;
                dtgRegistros.DataSource = _EDITORIALES;
                lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
            }
            catch
            { }
        }
        public GestionEditoriales(bool select = false)
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

        private void GestionEditoriales_Load(object sender, EventArgs e)
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
            EdicionEditorial frm = new EdicionEditorial();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EdicionEditorial frm = new EdicionEditorial();
            frm.txtIDEditorial.Text = dtgRegistros.CurrentRow.Cells["IDEditorial"].Value.ToString();
            frm.txtEditorial.Text = dtgRegistros.CurrentRow.Cells["Editorial"].Value.ToString();
            frm.txtDireccion.Text = dtgRegistros.CurrentRow.Cells["Direccion"].Value.ToString();
            frm.txtTelefono.Text = dtgRegistros.CurrentRow.Cells["Telefono"].Value.ToString();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Editoriales oEditorial = new CLS.Editoriales();
                oEditorial.IDEditorial = dtgRegistros.CurrentRow.Cells["IDEditorial"].Value.ToString();
                if (oEditorial.Eliminar())
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
            IDEdit = dtgRegistros.CurrentRow.Cells["IDEditorial"].Value.ToString();
            Nomb = dtgRegistros.CurrentRow.Cells["Nombres"].Value.ToString();
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
