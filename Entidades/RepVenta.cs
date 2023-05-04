using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RepVenta
    {
        public string IDVenta { get; set; }
        public string IDEmpleado { get; set; }
        public string NoSerie { get; set; }
        public string Fecha { get; set; }
        public double Subtotal { get; set; }
        public string TipoVenta { get; set; }
    }
}
