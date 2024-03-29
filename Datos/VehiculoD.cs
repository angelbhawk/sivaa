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
    public class VehiculoD
    {
        string CdCnx = ConfigurationManager.ConnectionStrings["CnxSQL"].ToString();
        public void Insertar(Vehiculo Pqte)
        {
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abrir la conexión y crear el Query
                Cnx.Open();
                string CdSql = "INSERT INTO Vehiculo (IDVehiculo,Nombre) VALUES (@Cl,@Nm)";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))//SolicitA: la cadena de SQL y la conexeión
                {
                    //Añadir los parámetros
                    Cmd.Parameters.AddWithValue("@Cl", Pqte.IDVehiculo);//Get y set de la capa entidad
                    Cmd.Parameters.AddWithValue("@Nm", Pqte.Nombre);
                    Cmd.ExecuteNonQuery();
                    //Borrar variable cmd de la memoria
                    Cmd.Dispose();
                }
                //Cierre
                Cnx.Close();
            }
        }

        public List<Vehiculo> ListadoTotal()
        {
            List<Vehiculo> productos = new List<Vehiculo>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Venta
                string CdSql = "Select * from Vehiculo";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Vehiculo Pqte = new Vehiculo
                        {
                            IDVehiculo = Convert.ToString(Dr["IDVehiculo"]),
                            Nombre = Convert.ToString(Dr["Nombre"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public Vehiculo ObtenerPdto(string CodPqt)
        {
            //Using que crea la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abro la conexión y creo el Query insertar, eliminar, consultar, elminar, actualizar, consulta individaul, general, orrar todo
                Cnx.Open();
                string CdSql = "SELECT * FROM Vehiculo WHERE IDVehiculo=@Cl";
                //Using que crea el comando que voy a ejecutar con relación al query que planeteo
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    if (Dr.Read())
                    {

                        Vehiculo Pqte = new Vehiculo
                        {
                            IDVehiculo = Convert.ToString(Dr["IDVehiculo"]),
                            Nombre = Convert.ToString(Dr["Nombre"])
                        };
                        return Pqte;
                    }
                }
                Cnx.Close();
            }
            return null;
        }
        public Vehiculo ObtenerPdtoPorNombre(string CodPqt)
        {

            //Using que crea la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abro la conexión y creo el Query insertar, eliminar, consultar, elminar, actualizar, consulta individaul, general, orrar todo
                Cnx.Open();
                string CdSql = "SELECT * FROM Vehiculo WHERE Nombre=@Cl";
                //Using que crea el comando que voy a ejecutar con relación al query que planeteo
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    if (Dr.Read())
                    {

                        Vehiculo Pqte = new Vehiculo
                        {
                            IDVehiculo = Convert.ToString(Dr["IDVehiculo"]),
                            Nombre = Convert.ToString(Dr["Nombre"])
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
                string CdSql = "DELETE FROM Vehiculo WHERE IDVehiculo=@Cl";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();
                }
                Cnx.Close();
            }
        }
        public List<Vehiculo> OrdenarID()
        {
            List<Vehiculo> productos = new List<Vehiculo>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Venta
                string CdSql = "Select * from Vehiculo Order by IDVehiculo";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Vehiculo Pqte = new Vehiculo
                        {
                            IDVehiculo = Convert.ToString(Dr["IDVehiculo"]),
                            Nombre = Convert.ToString(Dr["Nombre"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public List<Vehiculo> OrdenarNombre()
        {
            List<Vehiculo> productos = new List<Vehiculo>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Venta
                string CdSql = "Select * from Vehiculo Order by Nombre";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Vehiculo Pqte = new Vehiculo
                        {
                            IDVehiculo = Convert.ToString(Dr["IDVehiculo"]),
                            Nombre = Convert.ToString(Dr["Nombre"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public void Actualizar(Vehiculo Pqte)
        {
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                string CdSql = "UPDATE Vehiculo SET Nombre=@Nm WHERE IDVehiculo=@Cl";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Añadir los parámetros
                    Cmd.Parameters.AddWithValue("@Cl", Pqte.IDVehiculo);//Get y set de la capa entidad
                    Cmd.Parameters.AddWithValue("@Nm", Pqte.Nombre);
                    Cmd.ExecuteNonQuery();
                    //Borrar variable cmd de la memoria
                    Cmd.Dispose();
                }
                Cnx.Close();
            }
        }

        public List<Vehiculo> ListadoEspecifico(string CodPqt, string opcion)
        {
            List<Vehiculo> productos = new List<Vehiculo>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Proveedor

                string CdSql = "SELECT * from Vehiculo WHERE " + opcion + "=@Cl";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Vehiculo Pqte = new Vehiculo
                        {
                            IDVehiculo = Convert.ToString(Dr["IDVehiculo"]),
                            Nombre = Convert.ToString(Dr["Nombre"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

    }
}
