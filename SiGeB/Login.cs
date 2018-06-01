using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIF
{
    public partial class Login : Form
    {
        Boolean _Autorizado = false;
        SessionController.Sesion _SESION = SessionController.Sesion.Instance;
        public Login()
        {
            InitializeComponent();
        }

        public bool Autorizado
        {
            get
            {
                return _Autorizado;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (_SESION.ValidarSesion(txbUsuario.Text, txbPassword.Text))
            {
                _Autorizado =true;
                Close();
            }
            else
            {
                lblMensaje.Text = "DATOS ERRONEOS";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            RectangleF rect = new RectangleF(0,0,this.Width,this.Height);
            GraphicsPath gp = Functions.Class1.MakeRoundedRect(rect,20,20,true,true,true,true);
            this.Region = new Region(gp);
        }

        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (_SESION.ValidarSesion(txbUsuario.Text, txbPassword.Text))
                {
                    _Autorizado = true;
                    Close();
                }
                else
                {
                    lblMensaje.Text = "DATOS ERRONEOS";
                }
            }
        }
    }
}
