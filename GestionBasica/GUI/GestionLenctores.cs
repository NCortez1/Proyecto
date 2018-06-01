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
    public partial class GestionLenctores : Form
    {
        BindingSource _LECTORES = new BindingSource();
        public bool Seleccionar = false;
        public GestionLenctores(bool select = false)
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
    }
}
