using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _practica
{
    public class Encomienda : Servicio
    {
        string EncomiendaDesc { get; set;  }
        int EncomiendaID { get;  set;  }
        public Bus Bus { get; set; }

        public Encomienda()
        { 
         }
        public Encomienda(string servicioDesc)
            : base(servicioDesc)
        { 
        }
        public Encomienda(Bus bus) 
        {
            Bus = bus;
        }
        public Encomienda(int encomiendaID) 
        {
            EncomiendaID = encomiendaID;
        }
    }

}
