using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _practica
{
    public class TipoLugar
    {
        string tipoLugar ;
        public string tipoLugar2 
        {
            get { return tipoLugar; }
            set { if (value.Length > 0) tipoLugar = value; }
        }




        public TipoLugar() { }
        public TipoLugar(string tipo) 
        {
            tipoLugar = tipo;
        }
    }
}
