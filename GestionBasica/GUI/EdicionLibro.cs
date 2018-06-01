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
    public partial class EdicionLibro : Form
    {
        public EdicionLibro()
        {
            InitializeComponent();
            CargarCategorias();
            CargarEditoriales();
            CargarAutores();
        }
        private void CargarEditoriales()
        {
            DataTable Editoriales = new DataTable();
            Editoriales = CacheController.Cache.TODAS_LAS_EDITORIALES();
            cmbEditoriales.DataSource = Editoriales;
            cmbEditoriales.DisplayMember = "Nombre";
            cmbEditoriales.ValueMember = "IDEditorial";
        }
        private void CargarCategorias()
        {
            DataTable Categorias = new DataTable();
            Categorias = CacheController.Cache.TODAS_LAS_CATEGORIAS();
            cmbCategorias.DataSource = Categorias;
            cmbCategorias.DisplayMember = "Categoria";
            cmbCategorias.ValueMember = "IDCategoria";
        }
        private void CargarAutores()
        {
            DataTable Autores = new DataTable();
            Autores = CacheController.Cache.TODOS_LOS_AUTORES();
            cmbCategorias.DataSource = Autores;
            cmbCategorias.DisplayMember = "Nombre";
            cmbCategorias.ValueMember = "IDAutor";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CLS.Libros oLibro = new CLS.Libros();
            oLibro.IDLibro = txtIDLibro.Text;
            oLibro.Titulo = txtTitulo.Text;
            oLibro.IDAutor = cmbAutores.SelectedValue.ToString();
            oLibro.IDEditorial = cmbEditoriales.SelectedValue.ToString();
            oLibro.IDCategoria = cmbCategorias.SelectedValue.ToString();
            oLibro.Edicion = txtEdicion.Text;
            oLibro.Paginas = txtPaginas.Text;
            oLibro.Contenidos = txtContenidos.Text;
            oLibro.Fecha_Lanzamiento = dtFecha.Text;
            oLibro.Portada = pbxPortada.Image;

            if (txtIDLibro.TextLength > 0)
            {
                if (oLibro.Actualzar())
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
                if (oLibro.Insertar())
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

        private void pbxPortada_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivo JPG|*.jpg";

            if (file.ShowDialog() == DialogResult.OK)
            {
                pbxPortada.Image = Image.FromFile(file.FileName);
            }
        }
    }
}
