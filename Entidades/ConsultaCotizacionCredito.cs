using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ConsultaCotizacionCredito
    {
        public string IDCotizacion { get; set; }
        public string IDCliente { get; set; }
        public string Cliente { get; set; }
        public string IDVehiculo { get; set; }
        public string IDEmpleado { get; set; }
        public string PrecioInicial { get; set; }
        public string TipoPago { get; set; }
        public string Nombre { get; set; }
        public string Año { get; set; }
        public string Color { get; set; }
        public string NoSerie { get; set; }
    }
}
