using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _practica
{
    public class Transporte : Servicio
    {
        public List<Bus> _Bus;
        private TipoViaje _TipoViaje;
        private List<TipoViaje> _TipoViaje2;
        private Cliente _Cliente;
        private LugarViaje _LugarViaje;
        public List<Bus> bus 
        {
            get { return _Bus; }
            set { if (value.Count > 0) _Bus = value; }
        }
        public Transporte(TipoViaje tipoViaje , Cliente cliente, LugarViaje lugarViaje) 
        {
            _TipoViaje = tipoViaje;
            _Cliente = cliente;
            _LugarViaje = lugarViaje;
        }
        public Transporte() 
        {
            _TipoViaje2 = new List<TipoViaje>();
        }
        public Transporte(string servicioDesc)
            : base(servicioDesc)
        { }
        public Transporte(List<Bus> bus) 
        {
            _Bus = bus;
        }
        
        public void TipoViajeSet(string tipoViajes) 
        {
            if (tipoViajes != null) 
            {
               // _TipoViaje = new TipoViaje(tipoViajes);
                _TipoViaje2.Add(new TipoViaje(tipoViajes));

            }
 
        }
       /* public TipoViaje TipoViaje { set; get; }
        public Cliente Cliente { set; get; }
        public LugarViaje LugarViaje { set; get; }
        * */
    }
}
