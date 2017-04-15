using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _practica
{
    public class Administrativo :Empleados 
    {
        string AdministrativoDesc { get; set; }
        public Administrativo(string empleadosid)
            : base(empleadosid)
        {
        }
        public Administrativo() { }

    }
}
