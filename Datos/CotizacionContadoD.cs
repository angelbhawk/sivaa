using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CotizacionContadoD
    {
        //CnxSQL es la variable en app.config que contiene el nombre del servidor y de los datos en la base de datos
        //string CdCnx = @"server=DESKTOP-P7GH3IM\MSSQLSERVER01 ; integrated security = true database=SIIVA";
        string CdCnx = ConfigurationManager.ConnectionStrings["CnxSQL"].ToString();
        public void Insertar(CotizacionContado Pqte)
        {
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abrir la conexión y crear el Query
                Cnx.Open();
                string CdSql = "INSERT INTO CotizacionContado (IDCotizacion) VALUES (@Cl)";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))//SolicitA: la cadena de SQL y la conexeión
                {
                    //Añadir los parámetros
                    Cmd.Parameters.AddWithValue("@Cl", Pqte.IDCotizacion);//Get y set de la capa entidad
                    Cmd.ExecuteNonQuery();
                    //Borrar variable cmd de la memoria
                    Cmd.Dispose();
                }
                //Cierre
                Cnx.Close();
            }
        }

        public List<ConsultaCotizacionesContado> ListadoTotal()
        {
            List<ConsultaCotizacionesContado> productos = new List<ConsultaCotizacionesContado>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla CotizacionContado
                string CdSql = "SELECT c.IDCotizacion, c.IDCliente, CONCAT(TRIM(cli.Nombre),' ',TRIM(cli.ApellidoPaterno),' ',TRIM(cli.ApellidoMaterno)) as Cliente,v.IDVehiculo, c.IDEmpleado, c.PrecioInicial, c.TipoPago, v.Nombre,m.Año,u.Color,u.NoSerie\r\nFROM Cotizacion as c\r\nINNER JOIN CotizacionContado AS con\r\nON con.IDCotizacion = c.IDCotizacion\r\nINNER JOIN Cliente as cli\r\nON c.IDCliente = cli.IDCliente\r\nINNER JOIN [Version] as ver\r\nON c.IDVersion = ver.IDVersion\r\nINNER JOIN Vehiculo as v\r\nON ver.IDVehiculo = v.IDVehiculo\r\nINNER JOIN Modelo  as m\r\nON ver.IDModelo = m.IDModelo\r\nINNER JOIN Unidad as u\r\nON u.IDVersion = ver.IDVersion\r\nWHERE c.TipoPago = 'Contado'";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ConsultaCotizacionesContado Pqte = new ConsultaCotizacionesContado
                        {
                            IDCotizacion = Convert.ToString(Dr["IDCotizacion"]),
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            Cliente = Convert.ToString(Dr["Cliente"]),
                            IDVehiculo = Convert.ToString(Dr["IDVehiculo"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            PrecioInicial = Convert.ToString(Dr["PrecioInicial"]),
                            TipoPago = Convert.ToString(Dr["TipoPago"]),
                            Nombre = Convert.ToString(Dr["Nombre"]),
                            Año = Convert.ToString(Dr["Año"]),
                            Color = Convert.ToString(Dr["Color"]),
                            NoSerie = Convert.ToString(Dr["NoSerie"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public CotizacionContado ObtenerPdto(string CodPqt)
        {
            //Using que crea la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abro la conexión y creo el Query insertar, eliminar, consultar, elminar, actualizar, consulta individaul, general, orrar todo
                Cnx.Open();
                string CdSql = "SELECT * FROM CotizacionContado WHERE IDCotizacion=@Cl";
                //Using que crea el comando que voy a ejecutar con relación al query que planeteo
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    if (Dr.Read())
                    {

                        CotizacionContado Pqte = new CotizacionContado
                        {
                            IDCotizacion = Convert.ToString(Dr["IDCotizacion"])
                        };
                        return Pqte;
                    }
                }
                Cnx.Close();
            }
            return null;
        }

        public void Eliminar(string CodPqt)
        {
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                string CdSql = "DELETE FROM CotizacionContado WHERE IDCotizacion=@Cl";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();
                }
                Cnx.Close();
            }



        }

        public void Actualizar(CotizacionContado Pqte)
        {
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                string CdSql = "UPDATE CotizacionContado SET IDCotizacion=@Cl WHERE IDCotizacion=@Cl";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Añadir los parámetros
                    Cmd.Parameters.AddWithValue("@Cl", Pqte.IDCotizacion);//Get y set de la capa entidad
                    Cmd.ExecuteNonQuery();
                    //Borrar variable cmd de la memoria
                    Cmd.Dispose();
                }
                Cnx.Close();
            }
        }
    }
}
