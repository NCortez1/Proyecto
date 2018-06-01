using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SIF
{
    public partial class Prueba : Form
    {
        private void CargarDatos()
        {
            DataController.Operacion oConsulta = new DataController.Operacion();
            DataTable Datos = new DataTable();
            Datos = oConsulta.Consultar("Select * from Roles;");
            dtgTabla.DataSource = Datos;
        }
        public Prueba()
        {
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
