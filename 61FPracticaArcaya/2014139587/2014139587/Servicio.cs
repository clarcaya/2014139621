using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _practica
{
    public class Servicio
    {
        public int ServicioUID { set; get; }
        public string ServicioDESC { set; get; }
        public Servicio() 
        {
        }
        public Servicio(string servicioDesc) 
        {
            ServicioDESC = servicioDesc;
        }
    }
}
