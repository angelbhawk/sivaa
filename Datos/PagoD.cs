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
    public class PagoD
    {
        //CnxSQL es la variable en app.config que contiene el nombre del servidor y de los datos en la base de datos
        //string CdCnx = @"server=DESKTOP-P7GH3IM\MSSQLSERVER01 ; integrated security = true database=SIIVA";
        string CdCnx = ConfigurationManager.ConnectionStrings["CnxSQL"].ToString();
        public void Insertar(Pago Pqte)
        {
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abrir la conexión y crear el Query
                Cnx.Open();
                string CdSql = "INSERT INTO Pago (IDPago,IDVenta,IDEmpleado,Monto,FormaPago,Dia,Mes,Año) VALUES (@Cl,@Nm,@emp,@mon,@fp,@d,@m,@a)";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))//SolicitA: la cadena de SQL y la conexeión
                {
                    //Añadir los parámetros
                    Cmd.Parameters.AddWithValue("@Cl", Pqte.IDPago);//Get y set de la capa entidad
                    Cmd.Parameters.AddWithValue("@Nm", Pqte.IDVenta);
                    Cmd.Parameters.AddWithValue("@emp", Pqte.IDEmpleado);
                    Cmd.Parameters.AddWithValue("@mon", Pqte.Monto);
                    Cmd.Parameters.AddWithValue("@fp", Pqte.FormaPago);
                    Cmd.Parameters.AddWithValue("@d", Pqte.Dia);
                    Cmd.Parameters.AddWithValue("@m", Pqte.Mes);
                    Cmd.Parameters.AddWithValue("@a", Pqte.Año);
                    Cmd.ExecuteNonQuery();
                    //Borrar variable cmd de la memoria
                    Cmd.Dispose();
                }
                //Cierre
                Cnx.Close();
            }
        }

        public List<Pago> ListadoTotal()
        {
            List<Pago> productos = new List<Pago>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla cliente
                string CdSql = "Select * from Pago";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Pago Pqte = new Pago
                        {
                            IDPago = Convert.ToString(Dr["IDPago"]),
                            IDVenta = Convert.ToString(Dr["IDVenta"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            Monto = Convert.ToDouble(Dr["Monto"]),
                            FormaPago = Convert.ToString(Dr["FormaPago"]),
                            Dia = Convert.ToInt32(Dr["Dia"]),
                            Mes = Convert.ToInt32(Dr["Mes"]),
                            Año = Convert.ToInt32(Dr["Año"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public Pago ObtenerPdto(string CodPqt)
        {
            //Using que crea la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abro la conexión y creo el Query insertar, eliminar, consultar, elminar, actualizar, consulta individaul, general, orrar todo
                Cnx.Open();
                string CdSql = "SELECT * FROM Pago WHERE IDPago=@Cl";
                //Using que crea el comando que voy a ejecutar con relación al query que planeteo
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    //Cmd.Parameters.AddWithValue("@Con", Con);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    if (Dr.Read())
                    {

                        Pago Pqte = new Pago
                        {
                            IDPago = Convert.ToString(Dr["IDPago"]),
                            IDVenta = Convert.ToString(Dr["IDVenta"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            Monto = Convert.ToDouble(Dr["Monto"]),
                            FormaPago = Convert.ToString(Dr["FormaPago"]),
                            Dia = Convert.ToInt32(Dr["Dia"]),
                            Mes = Convert.ToInt32(Dr["Mes"]),
                            Año = Convert.ToInt32(Dr["Año"])
                        };
                        return Pqte;
                    }
                }
                Cnx.Close();
            }
            return null;
        }
        public Pago Obtenerpagosefectivo(string CodPqt)
        {
            //Using que crea la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abro la conexión y creo el Query insertar, eliminar, consultar, elminar, actualizar, consulta individaul, general, orrar todo
                Cnx.Open();
                string CdSql = "select CorteCajaPago.IDCortecaja,SUM(Pago.Monto) FinalEfec \r\nfrom Pago, CorteCajaPago where Pago.FormaPago='EFECTIVO' and CorteCajaPago.IDPago=Pago.IDPago\r\nand CorteCajaPago.IDCortecaja=@Cl\r\ngroup by IDCortecaja";
                //Using que crea el comando que voy a ejecutar con relación al query que planeteo
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    //Cmd.Parameters.AddWithValue("@Con", Con);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    if (Dr.Read())
                    {

                        Pago Pqte = new Pago
                        {
                            IDVenta = Convert.ToString(Dr["IDCorteCaja"]),
                            Monto = Convert.ToDouble(Dr["FinalEfec"])
                        };
                        return Pqte;
                    }
                }
                Cnx.Close();
            }
            return null;
        }
        public Pago Obtenerpagostarjeta(string CodPqt)
        {
            //Using que crea la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abro la conexión y creo el Query insertar, eliminar, consultar, elminar, actualizar, consulta individaul, general, orrar todo
                Cnx.Open();
                string CdSql = "select CorteCajaPago.IDCortecaja,SUM(Pago.Monto) FinalEfec \r\nfrom Pago, CorteCajaPago where Pago.FormaPago='TARJETA' and CorteCajaPago.IDPago=Pago.IDPago\r\nand CorteCajaPago.IDCortecaja=@Cl\r\ngroup by IDCortecaja";
                //Using que crea el comando que voy a ejecutar con relación al query que planeteo
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    //Cmd.Parameters.AddWithValue("@Con", Con);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    if (Dr.Read())
                    {

                        Pago Pqte = new Pago
                        {
                            IDVenta = Convert.ToString(Dr["IDCorteCaja"]),
                            Monto = Convert.ToDouble(Dr["FinalEfec"])
                        };
                        return Pqte;
                    }
                }
                Cnx.Close();
            }
            return null;
        }

        //public void Eliminar(string CodPqt)
        //{
        //    using (SqlConnection Cnx = new SqlConnection(CdCnx))
        //    {
        //        Cnx.Open();
        //        string CdSql = "DELETE FROM Cliente WHERE IDEmpleado=@Cl";
        //        using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
        //        {
        //            Cmd.Parameters.AddWithValue("@Cl", CodPqt);
        //            Cmd.ExecuteNonQuery();
        //            Cmd.Dispose();
        //        }
        //        Cnx.Close();
        //    }
        //}

        //public void Actualizar(Empleado Pqte)
        //{
        //    using (SqlConnection Cnx = new SqlConnection(CdCnx))
        //    {
        //        Cnx.Open();
        //        string CdSql = "UPDATE Empleado SET Nombre=@Nm,ApellidoPaterno=@App, ApellidoMaterno=@Apm,RFC=@Rfc,Correo=@Cr,Telefono=@Tl,Contraseña=@Co, Tipo=@Ti WHERE IDEmpleado=@Cl";
        //        using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
        //        {
        //            //Añadir los parámetros
        //            Cmd.Parameters.AddWithValue("@Cl", Pqte.IDEmpleado);//Get y set de la capa entidad
        //            Cmd.Parameters.AddWithValue("@Nm", Pqte.Nombre);
        //            Cmd.Parameters.AddWithValue("@App", Pqte.ApellidoPat);
        //            Cmd.Parameters.AddWithValue("@Apm", Pqte.ApellidoMat);
        //            Cmd.Parameters.AddWithValue("@Cr", Pqte.Correo);
        //            Cmd.Parameters.AddWithValue("@Tl", Pqte.Telefono);
        //            Cmd.Parameters.AddWithValue("@Rfc", Pqte.RFC);
        //            Cmd.Parameters.AddWithValue("@Co", Pqte.Contraseña);
        //            Cmd.Parameters.AddWithValue("@Ti", Pqte.Tipo);
        //            Cmd.ExecuteNonQuery();
        //            //Borrar variable cmd de la memoria
        //            Cmd.Dispose();
        //        }
        //        Cnx.Close();
        //    }
        //}
    }
}
