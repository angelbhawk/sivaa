﻿using Entidades;
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
        public void Eliminar(string CodPqt)
        {
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                string CdSql = "DELETE FROM Cotizacion WHERE IDCliente=@Cl";
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
