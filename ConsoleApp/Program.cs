using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloBD;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grabar grabar = new Grabar();
            grabar.DatosIni();

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
        }
    }
}
