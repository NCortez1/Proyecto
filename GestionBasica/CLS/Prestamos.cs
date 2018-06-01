using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Prestamos
    {
        String _IDPrestamo;
        String _IDlector;
        String _Fecha_Entrega;
        String _Fecha_Limite;
        String _Estado;
        String _Mora;

        public string IDPrestamo
        {
            get
            {
                return _IDPrestamo;
            }

            set
            {
                _IDPrestamo = value;
            }
        }

        public string IDlector
        {
            get
            {
                return _IDlector;
            }

            set
            {
                _IDlector = value;
            }
        }

        public string Fecha_Entrega
        {
            get
            {
                return _Fecha_Entrega;
            }

            set
            {
                _Fecha_Entrega = value;
            }
        }

        public string Fecha_Limite
        {
            get
            {
                return _Fecha_Limite;
            }

            set
            {
                _Fecha_Limite = value;
            }
        }

        public string Mora
        {
            get
            {
                return _Mora;
            }

            set
            {
                _Mora = value;
            }
        }

        public string Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }

    }
}
