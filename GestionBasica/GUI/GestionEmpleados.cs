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
    public partial class GestionEmpleados : Form
    {
        BindingSource _EMPLEADOS = new BindingSource();
        public bool Seleccionar = false;
        public String IDEmp;
        public String Emp;

        public GestionEmpleados(bool select=false)
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

        private void GestionEmpleados_Load(object sender, EventArgs e)
        {
            CargarDatos();
            alternarColores(dtgRegistros);
        }

        private void CargarDatos()
        {
            _EMPLEADOS.DataSource = CacheController.Cache.TODOS_LOS_EMPLEADOS();
            dtgRegistros.DataSource = _EMPLEADOS;
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
                    _EMPLEADOS.Filter = "Apellidos LIKE '%" + txtFiltro.Text + "%'";
                }
                else
                {
                    _EMPLEADOS.RemoveFilter();
                }
                dtgRegistros.AutoGenerateColumns = false;
                dtgRegistros.DataSource = _EMPLEADOS;
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
            EdicionEmpleado frm = new EdicionEmpleado();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar = true;
            IDEmp = dtgRegistros.CurrentRow.Cells["IDEmpleado"].Value.ToString();
            Emp = dtgRegistros.CurrentRow.Cells["Nombres"].Value.ToString() + " " + dtgRegistros.CurrentRow.Cells["Apellidos"].Value.ToString(); ;
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EdicionEmpleado frm = new EdicionEmpleado();
            frm.txtIDEmpleado.Text = dtgRegistros.CurrentRow.Cells["IDEmpleado"].Value.ToString();
            frm.txtNombres.Text = dtgRegistros.CurrentRow.Cells["Nombres"].Value.ToString();
            frm.txtApellidos.Text = dtgRegistros.CurrentRow.Cells["Apellidos"].Value.ToString();
            frm.dtFecha.Text = dtgRegistros.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
            frm.cmbGenero.SelectedItem = dtgRegistros.CurrentRow.Cells["Genero"].Value.ToString();
            
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
                CLS.Empleados oEmpleado = new CLS.Empleados();
                oEmpleado.IDEmpleado = dtgRegistros.CurrentRow.Cells["IDEmpleado"].Value.ToString();
                if (oEmpleado.Eliminar())
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
