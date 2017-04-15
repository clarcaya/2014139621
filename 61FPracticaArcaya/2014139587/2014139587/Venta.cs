using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _practica
{
    public  class Venta
    {
         List<Servicio> _Servicio;
         List<Cliente> _Cliente;
         TipoComprobante _TipoComprovante;
         TipoPago _TipoPago;
         Administrativo _Administrativo;
         public Venta()
         {
             _Cliente = new List<Cliente>();
             _TipoComprovante = new TipoComprobante();
             _TipoComprovante = new TipoComprobante();
             _TipoPago = new TipoPago();
             _Administrativo = new Administrativo();
             _Servicio = new List<Servicio>();
         }
        public void agregarServicio(string servicio)
        {
            if(servicio.Length >0)
            {
                _Servicio.Add(new Servicio(servicio));
            }
                
        }
        public void agregarUsuario(string NombreSet) 
        {
            if (NombreSet.Length > 0)
            {
                _Cliente.Add(new Cliente(NombreSet));

            }
            else return;
        }
       
        /*public string listarUsuario(int indice) 
        {
            _Cliente.
        }*/
    }
}
