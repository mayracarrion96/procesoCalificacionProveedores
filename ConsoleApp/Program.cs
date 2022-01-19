using Modelo.Entidades;
using ModeloBD;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista de proveedores
            Proveedor Dismap = new Proveedor() { Nombre = "Dismap", Ruc="1709451221001", Direccion="Francisco de Orellana E3-16", Telefono="3530324", Correo="ventas@dismap.com" };
            Proveedor Onerom = new Proveedor() { Nombre = "Onerom", Ruc = "1792645379001", Direccion = "Polonia N31-92", Telefono = "2548210", Correo = "ventas@onerom.com" };
            Proveedor Ecuaempaques = new Proveedor() { Nombre = "Ecuaempaques", Ruc = "1791350529001", Direccion = "Isacc Albeniz E5-101", Telefono = "2812860", Correo = "facturacion@ecuaempaques.com" };

            //Lista de periodos
            Periodo Periodo_2021 = new Periodo() 
            { 
                FechaInicio = new DateTime(2021, 01, 01), 
                FechaFin = new DateTime(2021, 12, 31), 
                Oferta = new List<Oferta>(),
                Postulacion = new List<Postulacion>(),
                Estado = "Pendiente"
            };

            //Postulacion
            Postulacion PostDismap_2021 = new Postulacion()
            {
                Estado="Pendiente",
                Fecha = new DateTime(2021, 2, 25),
                Proveedor = Dismap,
                Periodo = Periodo_2021,
                Postulacion_Detalle=new List<Postulacion_Det>()
                
            };
            /*
            Configuracion Config = new Configuracion()
            {
                NotaMinima = 15.1f,
                PesoNota1 = 0.05f,
                PesoNota2 = 0.20f,
                PesoNota3 = 0.15f,
                PesoNota4 = 0.20f,
                PesoNota5 = 0.15f,
                PesoNota6 = 0.15f,
                PesoNota7 = 0.10f
            };
            */

            Repositorio db = new Repositorio();
            db.postulaciones.Add(PostDismap_2021);
            db.SaveChanges();

        }
    }
}
