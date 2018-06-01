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
    public partial class GestionAutores : Form
    {
        BindingSource _AUTORES = new BindingSource();
        public bool Seleccionar = false;
        public String IDAut;
        public String Nomb;
        private void CargarDatos()
        {
            _AUTORES.DataSource = CacheController.Cache.TODOS_LOS_AUTORES();
            dtgRegistros.DataSource = _AUTORES;
            lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
        }
        private void FiltrarLocalmente()
        {
            try
            {
                if (txtFiltro.TextLength > 0)
                {
                    _AUTORES.Filter = "Nombre LIKE '%" + txtFiltro.Text + "%'";
                }
                else
                {
                    _AUTORES.RemoveFilter();
                }
                dtgRegistros.AutoGenerateColumns = false;
                dtgRegistros.DataSource = _AUTORES;
                lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
            }
            catch
            { }
        }
        public GestionAutores(bool select = false)
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

        private void GestionAutores_Load(object sender, EventArgs e)
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
            EdicionAutor frm = new EdicionAutor();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EdicionAutor frm = new EdicionAutor();
            frm.txtIDAutor.Text = dtgRegistros.CurrentRow.Cells["IDAutor"].Value.ToString();
            frm.txtAutor.Text = dtgRegistros.CurrentRow.Cells["Nombre"].Value.ToString();
            frm.dtFecha.Text = dtgRegistros.CurrentRow.Cells["Fecha_Nacimiento"].Value.ToString();
            frm.txtResidencia.Text = dtgRegistros.CurrentRow.Cells["Residencia"].Value.ToString();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Autores oAutor = new CLS.Autores();
                oAutor.IDAutor = dtgRegistros.CurrentRow.Cells["IDAutor"].Value.ToString();
                if (oAutor.Eliminar())
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

        //------------------ Color de filas datagridview ------------
        private void alternarColores(DataGridView dtg)
        {
            dtg.RowsDefaultCellStyle.BackColor = Color.DarkGray;
            dtg.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }
    }
}
