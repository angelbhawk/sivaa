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
    public class CotizacionD
    {
        //CnxSQL es la variable en app.config que contiene el nombre del servidor y de los datos en la base de datos
        //string CdCnx = @"server=DESKTOP-P7GH3IM\MSSQLSERVER01 ; integrated security = true database=SIIVA";
        string CdCnx = ConfigurationManager.ConnectionStrings["CnxSQL"].ToString();
        public void Insertar(CotizacionUsar Pqte)
        {
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abrir la conexión y crear el Query
                Cnx.Open();
                string CdSql = "INSERT INTO Cotizacion (IDCotizacion,IDVersion,IDCliente,IDEmpleado,Dia,Mes,Año,PrecioInicial,TipoPago) VALUES (@Cl,@Nm,@App,@Apm,@Ap,@Rfc,@Cr,@Tl,@No)";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))//SolicitA: la cadena de SQL y la conexeión
                {
                    //Añadir los parámetros
                    Cmd.Parameters.AddWithValue("@Cl", Pqte.IDCotizacion);//Get y set de la capa entidad
                    Cmd.Parameters.AddWithValue("@Nm", Pqte.IDVersion);
                    Cmd.Parameters.AddWithValue("@App", Pqte.IDCliente);
                    Cmd.Parameters.AddWithValue("@Apm", Pqte.IDEmpleado);
                    Cmd.Parameters.AddWithValue("@Ap", Pqte.Dia);
                    Cmd.Parameters.AddWithValue("@Rfc", Pqte.Mes);
                    Cmd.Parameters.AddWithValue("@Cr", Pqte.Año);
                    Cmd.Parameters.AddWithValue("@Tl", Pqte.PrecioInicial);
                    Cmd.Parameters.AddWithValue("@No", Pqte.TipoPago);
                    Cmd.ExecuteNonQuery();
                    //Borrar variable cmd de la memoria
                    Cmd.Dispose();
                }
                //Cierre
                Cnx.Close();
            }
        }

        public List<CotizacionUsar> ListadoTotal()
        {
            List<CotizacionUsar> productos = new List<CotizacionUsar>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Cotizacion
                string CdSql = "Select * from Cotizacion";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        CotizacionUsar Pqte = new CotizacionUsar
                        {
                            IDCotizacion = Convert.ToString(Dr["IDCotizacion"]),
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            Dia = Convert.ToInt32(Dr["Dia"]),
                            Mes = Convert.ToInt32(Dr["Mes"]),
                            Año = Convert.ToInt32(Dr["Año"]),
                            PrecioInicial = Convert.ToDouble(Dr["PrecioInicial"]),
                            TipoPago = Convert.ToString(Dr["TipoPago"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public List<CotizacionNoUsar> ListadoTabla()
        {
            List<CotizacionNoUsar> productos = new List<CotizacionNoUsar>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Cotizacion
                string CdSql = "SELECT ct.IDCotizacion, CONCAT(TRIM(c.Nombre),' ',TRIM(c.ApellidoPaterno),' ',TRIM(c.ApellidoMaterno)) as Cliente, CONCAT(TRIM(vh.Nombre),' ',TRIM(v.[Version])) as Vehiculo, CONCAT(TRIM(e.Nombre),' ',TRIM(e.ApellidoPaterno),' ',TRIM(e.ApellidoMaterno)) as Empleado, ct.PrecioInicial, ct.TipoPago\r\nFROM Cotizacion as ct\r\nINNER JOIN Cliente as c\r\nON c.IDCliente = ct.IDCliente\r\nINNER JOIN Empleado as e\r\nON e.IDEmpleado = ct.IDEmpleado\r\nINNER JOIN [Version] as v\r\nON v.IDVersion = ct.IDVersion\r\nINNER JOIN Vehiculo as vh\r\nON vh.IDVehiculo = v.IDVehiculo";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        CotizacionNoUsar Pqte = new CotizacionNoUsar
                        {
                            IDCotizacion = Convert.ToString(Dr["IDCotizacion"]),
                            Cliente = Convert.ToString(Dr["Cliente"]),
                            Vehiculo = Convert.ToString(Dr["Vehiculo"]),
                            Empleado = Convert.ToString(Dr["Empleado"]),
                            precioInicial = Convert.ToDouble(Dr["PrecioInicial"]),
                            Tipo = Convert.ToString(Dr["TipoPago"]),
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public CotizacionUsar ObtenerPdto(string CodPqt)
        {
            //Using que crea la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abro la conexión y creo el Query insertar, eliminar, consultar, elminar, actualizar, consulta individaul, general, orrar todo
                Cnx.Open();
                string CdSql = "SELECT * FROM Cotizacion WHERE IDCotizacion=@Cl";
                //Using que crea el comando que voy a ejecutar con relación al query que planeteo
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    if (Dr.Read())
                    {

                        CotizacionUsar Pqte = new CotizacionUsar
                        {
                            IDCotizacion = Convert.ToString(Dr["IDCotizacion"]),
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            Dia = Convert.ToInt32(Dr["Dia"]),
                            Mes = Convert.ToInt32(Dr["Mes"]),
                            Año = Convert.ToInt32(Dr["Año"]),
                            PrecioInicial = Convert.ToDouble(Dr["PrecioInicial"]),
                            TipoPago = Convert.ToString(Dr["TipoPago"])
                        };
                        return Pqte;
                    }
                }
                Cnx.Close();
            }
            return null;
        }

        public CotizacionUsar ObtenerPdtoPorVenta(string CodPqt)
        {
            //Using que crea la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abro la conexión y creo el Query insertar, eliminar, consultar, elminar, actualizar, consulta individaul, general, orrar todo
                Cnx.Open();
                string CdSql = "SELECT * FROM Cotizacion WHERE IDCotizacion=@Cl";
                //Using que crea el comando que voy a ejecutar con relación al query que planeteo
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    if (Dr.Read())
                    {

                        CotizacionUsar Pqte = new CotizacionUsar
                        {
                            IDCotizacion = Convert.ToString(Dr["IDCotizacion"]),
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            Dia = Convert.ToInt32(Dr["Dia"]),
                            Mes = Convert.ToInt32(Dr["Mes"]),
                            Año = Convert.ToInt32(Dr["Año"]),
                            PrecioInicial = Convert.ToDouble(Dr["PrecioInicial"]),
                            TipoPago = Convert.ToString(Dr["TipoPago"])
                        };
                        return Pqte;
                    }
                }
                Cnx.Close();
            }
            return null;
        }

        public List<CotizacionUsar> ListadoTotalESP(string nom)
        {
            List<CotizacionUsar> productos = new List<CotizacionUsar>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla cliente
                string CdSql = "SELECT * FROM Cotizacion WHERE IDCliente=@Cl and TipoPago='Contado'";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    Cmd.Parameters.AddWithValue("@Cl", nom);
                    //Cmd.Parameters.AddWithValue("@Ap", app);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        CotizacionUsar Pqte = new CotizacionUsar
                        {
                            IDCotizacion = Convert.ToString(Dr["IDCotizacion"]),
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            Dia = Convert.ToInt32(Dr["Dia"]),
                            Mes = Convert.ToInt32(Dr["Mes"]),
                            Año = Convert.ToInt32(Dr["Año"]),
                            PrecioInicial = Convert.ToDouble(Dr["PrecioInicial"]),
                            TipoPago = Convert.ToString(Dr["TipoPago"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public List<CotizacionUsar> ListadoTotalESPCred(string nom)
        {
            List<CotizacionUsar> productos = new List<CotizacionUsar>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla cliente
                string CdSql = "SELECT * FROM Cotizacion WHERE IDCliente=@Cl and TipoPago='Credito'";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    Cmd.Parameters.AddWithValue("@Cl", nom);
                    //Cmd.Parameters.AddWithValue("@Ap", app);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        CotizacionUsar Pqte = new CotizacionUsar
                        {
                            IDCotizacion = Convert.ToString(Dr["IDCotizacion"]),
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            Dia = Convert.ToInt32(Dr["Dia"]),
                            Mes = Convert.ToInt32(Dr["Mes"]),
                            Año = Convert.ToInt32(Dr["Año"]),
                            PrecioInicial = Convert.ToDouble(Dr["PrecioInicial"]),
                            TipoPago = Convert.ToString(Dr["TipoPago"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public List<CotiVh> ListaDisponibles()
        {
            List<CotiVh> productos = new List<CotiVh>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla cliente
                string CdSql = "SELECT v.IDVersion, vh.Nombre, v.[Version], m.Año, v.Costo\r\nFROM Unidad as u\r\nINNER JOIN [Version] as v\r\nON v.IDVersion = u.IDVersion\r\nINNER JOIN Vehiculo as vh\r\nON vh.IDVehiculo = v.IDVehiculo\r\nINNER JOIN ModeloVersion as mv\r\nON mv.IDVersion = v.IDVersion\r\nINNER JOIN Modelo as m\r\nON m.IDModelo = mv.IDModelo\r\nWHERE u.Estatus = 'Disponible'";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Cmd.Parameters.AddWithValue("@Ap", app);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        CotiVh Pqte = new CotiVh
                        {
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            Nombre = Convert.ToString(Dr["Nombre"]),
                            Version = Convert.ToString(Dr["Version"]),
                            Año = Convert.ToString(Dr["Año"]),
                            Costo = Convert.ToDouble(Dr["Costo"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }


        public void Eliminar(string CodPqt)
        {
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                string CdSql = "DELETE FROM Cotizacion WHERE IDCotizacion=@Cl";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();
                }
                Cnx.Close();
            }



        }

        public void Actualizar(CotizacionUsar Pqte)
        {
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                string CdSql = "UPDATE Cotizacion SET IDVersion=@Nm,IDCliente=@App, IDEmpleado=@Apm,Dia=Ap, Mes=@Rfc,Año=@Cr,PrecioInicial=@Tl,TipoPago=@No WHERE IDCotizacion=@Cl";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Añadir los parámetros
                    Cmd.Parameters.AddWithValue("@Cl", Pqte.IDCotizacion);//Get y set de la capa entidad
                    Cmd.Parameters.AddWithValue("@Nm", Pqte.IDVersion);
                    Cmd.Parameters.AddWithValue("@App", Pqte.IDCliente);
                    Cmd.Parameters.AddWithValue("@Apm", Pqte.IDEmpleado);
                    Cmd.Parameters.AddWithValue("@Ap", Pqte.Dia);
                    Cmd.Parameters.AddWithValue("@Rfc", Pqte.Mes);
                    Cmd.Parameters.AddWithValue("@Cr", Pqte.Año);
                    Cmd.Parameters.AddWithValue("@Tl", Pqte.PrecioInicial);
                    Cmd.Parameters.AddWithValue("@No", Pqte.TipoPago);
                    Cmd.ExecuteNonQuery();
                    //Borrar variable cmd de la memoria
                    Cmd.Dispose();
                }
                Cnx.Close();
            }
        }
    }
}
