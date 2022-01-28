using CargaDatos;
using Modelo.Entidades;
using ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CargaDatos.DatosIniciales;

namespace ConsoleApp
{
    public class Grabar
    {
        public void DatosIni()
        {
            DatosIniciales datos = new DatosIniciales();
            var listas = datos.CargaDatos();

            // Extraer del diccionario las listas
            var listaConfiguracion = (List<Configuracion>)listas[ListasTipo.Configuracion];
            var listaPeriodos = (List<Periodo>)listas[ListasTipo.Periodos];
            var listaProveedores = (List<Proveedor>)listas[ListasTipo.Proveedores];
            var listaMarcas = (List<Marca>)listas[ListasTipo.Marcas];
            var listaProductos = (List<Producto>)listas[ListasTipo.Productos];
            var listaClasificacion = (List<Clasificacion>)listas[ListasTipo.Clasificaciones];
            var listaOferta = (List<Oferta>)listas[ListasTipo.Ofertas];
            var listaOfertaDet = (List<Oferta_Det>)listas[ListasTipo.Ofertas_Det];
            var listaCalificacion = (List<Calificacion>)listas[ListasTipo.Calificaciones];
            var listaPostulacion = (List<Postulacion>)listas[ListasTipo.Postulaciones];
            var listaPostulacionDet = (List<Postulacion_Det>)listas[ListasTipo.Postulaciones_Det];
            
            //Grabar
            /*
            Repositorio db = new Repositorio();

            db.configuraciones.AddRange(listaConfiguracion);
            db.periodos.AddRange(listaPeriodos);
            db.proveedores.AddRange(listaProveedores);
            db.marcas.AddRange(listaMarcas);
            db.productos.AddRange(listaProductos);
            db.clasificaciones.AddRange(listaClasificacion);
            db.ofertas.AddRange(listaOferta);
            db.ofertas_det.AddRange(listaOfertaDet);
            db.calificaciones.AddRange(listaCalificacion);
            db.postulaciones.AddRange(listaPostulacion);
            db.postulaciones_det.AddRange(listaPostulacionDet);
            

            db.SaveChanges();
            */
        }

    }
}
