using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logicas
{
    public class ModeloLog
    {
        private ModeloD Pdto = new ModeloD();//No poner public
        public readonly StringBuilder Mensaje = new StringBuilder();
        public Modelo LeerPorClave(string ClPdto)
        {
            Modelo Pd = null;
            Mensaje.Clear();
            if (ClPdto == "0")
                Mensaje.Append("Por favor proporcionar una clave valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ObtenerPdto(ClPdto);
                if (Pd == null)
                    Mensaje.Append("Codigo de Vehiculo no existe en la B.D.");
                return Pd;
            }
            return null;
        }
    }
}
