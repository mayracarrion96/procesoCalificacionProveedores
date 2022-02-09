﻿using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloBD;
using Procesos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grabar grabar = new Grabar();
            grabar.DatosIni();

            /*
            using (var db = RepositorioBuilder.Crear())
            {

                var listaProveedores = db.proveedores
                    .Include(proveedor => proveedor.Postulacion)
                        .ThenInclude(proveedor => proveedor.Periodo)
                    ;

                Console.WriteLine("Listado de proveedores");
                foreach (var proveedor in listaProveedores)
                {
                    Console.WriteLine(
                        proveedor.Nombre + " " +
                        proveedor.Ruc + " " +
                        proveedor.Direccion
                     );
                    foreach(var post in proveedor.Postulacion)
                    {
                        Console.WriteLine(
                            " - " +
                            post.PostulacionId +" "+
                            post.Periodo.Nombre + " " +
                            post.Estado
                        );
                    }
                }

                //-------------------------------------------------------

                var listaOfertas = db.ofertas
                    .Include(oferta => oferta.Periodo);

                Console.WriteLine("Listado de ofertas");
                foreach (var oferta in listaOfertas)
                {
                    Console.WriteLine(
                        oferta.Nombre + " " +
                        oferta.ScoreBuro + " " +
                        oferta.Periodo.Nombre
                     );
                }
            }

            */
            
            using (var db = RepositorioBuilder.Crear())
            {
                
                var tmpPostulacion = db.postulaciones
                    .Where(postulacion =>

                    postulacion.Nombre == "Dilipa 2019" ||
                    postulacion.Nombre == "Dilipa 2020"
                    ).ToList();

                var tmpProveedor = db.proveedores
                    .Single(proveedor => proveedor.Nombre == "Dilipa CIA. LTDA.");

                ProAprobaciones proaprobaciones = new ProAprobaciones(db);

                foreach (var ofe in tmpPostulacion)
                {
                    var resultado = proaprobaciones.Califico(tmpProveedor, ofe);

                    Console.WriteLine(
                        "El proveedor " + tmpProveedor.Nombre +
                        (resultado ? " SI " : " NO ") +
                        " fue aceptado en la postulacion: " + ofe.Nombre
                    );
                }

            }
            
            /*
            using (var db = RepositorioBuilder.Crear())
            {
                ProValidacion valm = new ProValidacion(db);

                var tmpPostulacion = db.postulaciones
                    .Single(pos => pos.PostulacionId == 10);

                valm.Validacion(tmpPostulacion);

                var ValMatr = valm.Validacion(tmpPostulacion);

                Console.WriteLine("La postulacion para " + tmpPostulacion.Proveedor.Nombre + (ValMatr ? " ESTA VALIDADA" : " NO ESTA VALIDADA"));
                ;
            }

            */



        }
    }
}
