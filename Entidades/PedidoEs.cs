using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PedidoEs
    {
        public string IDPedido { get; set; }
        public string Empleado { get; set;}
        
        public string Proveedor { get; set; }

        public int Dia { get; set;}
        public int Mes { get; set;}
        public int Año { get; set;}

        public double Importe { get; set;}
    }
}
