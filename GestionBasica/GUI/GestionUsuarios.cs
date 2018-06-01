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
    public partial class GestionUsuarios : Form
    {
        BindingSource _USUARIOS = new BindingSource();
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
            alternarColores(dtgRegistros);
        }
        private void CargarDatos()
        {
            _USUARIOS.DataSource = CacheController.Cache.TODOS_LOS_USUARIOS();
            dtgRegistros.DataSource = _USUARIOS;
            lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
        }
        private void FiltrarLocalmente()
        {
            try
            {
                if (txtFiltro.TextLength > 0)
                {
                    _USUARIOS.Filter = "Nombre LIKE '%" + txtFiltro.Text + "%'";
                }
                else
                {
                    _USUARIOS.RemoveFilter();
                }
                dtgRegistros.AutoGenerateColumns = false;
                dtgRegistros.DataSource = _USUARIOS;
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
            EdicionUsuario frm = new EdicionUsuario();
            frm.ShowDialog();
            CargarDatos();
        }

        public static implicit operator GestionUsuarios(EdicionUsuario v)
        {
            throw new NotImplementedException();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EdicionUsuario frm = new EdicionUsuario(true);
            frm.txtIDUsuario.Text = dtgRegistros.CurrentRow.Cells["IDUsuario"].Value.ToString();
            frm.txtUsuario.Text = dtgRegistros.CurrentRow.Cells["Usuario"].Value.ToString();
            frm.txtIDEmpleado.Text = dtgRegistros.CurrentRow.Cells["IDEmpleado"].Value.ToString();
            frm.txtEmpleado.Text = dtgRegistros.CurrentRow.Cells["Nombre"].Value.ToString();
            frm.cmbRoles.SelectedValue = dtgRegistros.CurrentRow.Cells["IDRol"].Value.ToString();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Usuarios oUsuario = new CLS.Usuarios();
                oUsuario.IDUsuario = dtgRegistros.CurrentRow.Cells["IDUsuario"].Value.ToString();
                if (oUsuario.Eliminar())
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
