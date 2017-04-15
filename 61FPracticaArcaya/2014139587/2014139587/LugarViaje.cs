using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _practica
{
     public class LugarViaje
    {
         private TipoLugar _TipoLugar;
         public LugarViaje(TipoLugar tipoLugar) 
        {
            _TipoLugar = tipoLugar;
        }
         public TipoLugar lugarViaje { get { return _TipoLugar; } }
        public LugarViaje() { }
        public void agregarTipoLugar(string tipo) 
        {
            _TipoLugar = new TipoLugar(tipo);
        }
    }
}
