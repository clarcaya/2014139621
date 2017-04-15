using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _practica
{
    public class TipoViaje
    {
        string _TipoViajeDesc;
        public string TipoViajeDesc 
        {
            get { return _TipoViajeDesc; }
            set { if (value.Length > 0) _TipoViajeDesc = value; }
        }

        public TipoViaje(string tipoViaje) 
        {
            _TipoViajeDesc = tipoViaje;
        }
        public TipoViaje() {}
    }

}
