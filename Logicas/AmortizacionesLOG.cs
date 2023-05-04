﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logicas
{

    public class AmortizacionesLOG
    {
        private ClienteD pqtClien = new ClienteD();
        private VehiculoD vehiculoD = new VehiculoD();
        private VentaD PdtoVen = new VentaD(); //no poner publico
        private CotizacionD PdtoCot = new CotizacionD(); //no poner publico
        private VersionD pdtover = new VersionD();
        private ModeloD pdtomod = new ModeloD();
        private CotizacionCreditoD pdcotcred = new CotizacionCreditoD();
        private VersionD pdtversion = new VersionD();
        private VehiculoD pdtVehiculo = new VehiculoD();
        private ModeloD pdtmodelo = new ModeloD();
        private CotizacionContadoD pdtCotCon = new CotizacionContadoD();
        private VentaCreditoD pdtoventacred = new VentaCreditoD();
        private ModeloVersionD pdtModVer = new ModeloVersionD();
        public ModeloVersion ObtenerModeloVersion(string idversion)
        {
            ModeloVersion datos = pdtModVer.ObtenerPdto(idversion);
            return datos;
        }
        public CotizacionCredito ObtenerCotizacionCredito(string idcotizacion)
        {
            CotizacionCredito datos = pdcotcred.ObtenerPdto(idcotizacion);
            return datos;
        }
        public VentaCredito ObtenerVentaCredito(string idventa)
        {
            VentaCredito datos = pdtoventacred.ObtenerPdto(idventa);
            return datos;
        }
        public CotizacionContado ObtenerCotizacionContado(string idcotizacion)
        {
            CotizacionContado datos = pdtCotCon.ObtenerPdto(idcotizacion);
            return datos;
        }
        public CotizacionUsar ObtenerCotizacion(string idcotizacion)
        {
            CotizacionUsar datos = PdtoCot.ObtenerPdto(idcotizacion);
            return datos;
        }
        public Cliente ObtenerDatosCliente(string idcliente)
        {
            Cliente datos = pqtClien.ObtenerPdto(idcliente);
            return datos;

        }
        public Versiones ObtenerDatosVersions(string idVersion)
        {
            Versiones datos = pdtover.ObtenerPdto(idVersion);
            return datos;
        }
        public Vehiculo ObtenerDatosVehiculo(string Idvehiculo)
        {
            Vehiculo datos = pdtVehiculo.ObtenerPdto(Idvehiculo);
            return datos;
        }
        public Modelo ObtenerDatosModelo(string Idmodelo)
        {
            Modelo datos = pdtmodelo.ObtenerPdto(Idmodelo);
            return datos;
        }
    }
}
