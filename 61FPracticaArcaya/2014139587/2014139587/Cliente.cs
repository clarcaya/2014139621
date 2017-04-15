using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _practica
{
    public class Cliente
    {
        private string NombreCliente { set; get; }
        public string nombreCliente
        {
            get { return NombreCliente; }
            set { if (value.Length > 0) NombreCliente = value; }
        }
   
        public Cliente(string nombre) 
        {
            NombreCliente = nombre;
        }
        public Cliente() { }

    }
}
