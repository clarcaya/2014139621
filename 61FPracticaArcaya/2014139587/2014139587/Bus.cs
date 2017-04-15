using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _practica
{
    public class Bus
    {
        List<Tripulacion> _Tripulacion;

        int NumeroAsientos { get; set; }
        public List<Tripulacion> Tripulacion
        {
            get { return _Tripulacion; }
            set { if (value.Count > 0) _Tripulacion = value; }
        }
        public Bus(int numeroAsientos) 
        {
            NumeroAsientos = numeroAsientos;
        }
        public Bus(List<Tripulacion> tripulacion) 
        {
            _Tripulacion = tripulacion;
        }
    }
}
