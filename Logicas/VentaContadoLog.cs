﻿using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicas
{
    public class VentaContadoLog
    {
        private VentaContadoD Pdto = new VentaContadoD();//No poner public
        public readonly StringBuilder Mensaje = new StringBuilder();

        public void Registrar(VentaContado Pd)
        {
            Mensaje.Clear();
            if (ValidarProducto(Pd))
            {
                if (Pdto.ObtenerPdto(Pd.IDVenta) == null)
                    //No se encuentra el dato (El código no existe)
                    Pdto.Insertar(Pd);
                else
                    Mensaje.Append("El Codigo del VentaContado ya se encuentra en la B.D.");
            }
        }

        public List<VentaContado> ListadoAll()
        {
            //Método que obtiene la lista dinámica de todos los registro que tiene mi tabla
            return Pdto.ListadoTotal();
        }

        public VentaContado LeerPorClave(string ClPdto)
        {
            VentaContado Pd = null;
            Mensaje.Clear();
            if (ClPdto == "0")
                Mensaje.Append("Por favor proporcionar una clave valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ObtenerPdto(ClPdto);
                if (Pd == null)
                    Mensaje.Append("Codigo del VentaContado no existe en la B.D.");
                return Pd;
            }
            return null;
        }
        public VentaContado LeerPorClavevoucher(string ClPdto)
        {
            VentaContado Pd = null;
            Mensaje.Clear();
            if (ClPdto == "0")
                Mensaje.Append("Por favor proporcionar una clave valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ObtenerPdtovoucher(ClPdto);
                if (Pd == null)
                    Mensaje.Append("Codigo del voucher no existe en la B.D.");
                return Pd;
            }
            return null;
        }
        public void Eliminar(string CodPqte)
        {
            Mensaje.Clear();
            if (CodPqte == "0")
                Mensaje.Append("Por favor proporcionar un Codigo valido");
            if (Mensaje.Length == 0)
                Pdto.Eliminar(CodPqte);
        }

        private bool ValidarProducto(VentaContado Pq)
        {
            Mensaje.Clear();
            if (string.IsNullOrEmpty(Pq.IDCotizacion))
                Mensaje.Append("El campo de idcotizacion no puede estar vacio");
            return Mensaje.Length == 0;

        }
        private bool ValidarProductoest(string Pq)
        {
            Mensaje.Clear();
            if (string.IsNullOrEmpty(Pq))
                Mensaje.Append("Estatus no puede estar vacio");
            return Mensaje.Length == 0;

        }
        public void Modificar(VentaContado Pqte)
        {
            if (ValidarProducto(Pqte))
                Pdto.Actualizar(Pqte);


        }
        public void ModificarEstatus(string id, string est)
        {
            if (ValidarProductoest(est))
                Pdto.ActualizarEstatus(id, est);
        }
    }
}
