using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SIF
{
    class AppManager:ApplicationContext
    {
        public AppManager()
        {
            Splash();
            if(Login())
            {
                //SI EL USUARIO Y LA CONTRASEÑA SON CORRECTAS
                Principal frm = new Principal();
                frm.ShowDialog();
            }
            else
            {
                //SI EL USUARIO O LA CONTRASEÑA NO SON CORRECTOS
            }
        }
        private void Splash()
        {
            //CREAMOS UN OBJETO CON EL OPERADOR NEW
            Splash frm = new SIF.Splash();
            //MOSTRAMOS EL FORMULARIO
            frm.ShowDialog();
        }
        private Boolean Login()
        {
            //CREAMOS UN OBJETO LOGIN
            Login frm = new SIF.Login();
            //MOSTRAMOS EL OBJETO FORMULARIO
            frm.ShowDialog();
            //DEVOLVEMOS EL VALOR DE LA PROPIEDAD
            return frm.Autorizado; 
        }
    }
}
