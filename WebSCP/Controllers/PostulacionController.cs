using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Modelo.Operaciones;
using ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSCP.Controllers
{
    public class PostulacionController : Controller
    {
        private readonly Repositorio db;
        public PostulacionController(Repositorio db)
        {
            this.db = db;
        }

        //Recupera la lista de postulaciones y envia hacia la vista
        public IActionResult Index()
        {
            IEnumerable<Postulacion> listaPostulacion = db.postulaciones
                .Include(postulacion => postulacion.Proveedor)
                .Include(postulacion => postulacion.Oferta)
                .Include(postulacion => postulacion.Periodo);

            return View(listaPostulacion);
        }

        //Pantalla para validacion de la matricula
        public IActionResult Validar(int id)
        {
           var postulacion =db.postulaciones
                .Include(postulacion => postulacion.Proveedor)
                .Include(postulacion => postulacion.Oferta)
                .Include(postulacion => postulacion.Periodo)
                .Include(postulacion => postulacion.Postulacion_Detalle)
                    .ThenInclude(postulacion_det => postulacion_det.Calificacion)
                .Single(postulacion => postulacion.PostulacionId==id)
                 ;

            //Listas
            var listaProveedor = db.proveedores
                .Select(proveedor => new
                {
                    ProveedorId = proveedor.ProveedorId,
                    Nombre = proveedor.Nombre
                }).ToList();

            var listaOferta = db.ofertas
                .Select(oferta => new
                {
                    OfertaId = oferta.OfertaId,
                    Nombre = oferta.Nombre
                }).ToList();

            var listaPeriodo = db.periodos
               .Select(periodo => new
               {
                   PeriodoId = periodo.PeriodoId,
                   Nombre = periodo.Nombre
               }).ToList();

            var listaDetPost = db.postulaciones_det
                .Select(postulacion_det => new
                {
                    Postulacion_DetId = postulacion_det.Postulacion_DetId,
                    Nombre = postulacion_det.Nombre
                }).ToList();

            //Prepara las listas
            var selectListPeriodo = new SelectList(listaPeriodo, "PeriodoId", "Nombre");
            var selectListOfertas = new SelectList(listaOferta, "OfertaId", "Nombre");
            var selectListProveedores = new SelectList(listaProveedor, "ProveedorId", "Nombre");
            var selectListPostulacionesDet = new SelectList(listaDetPost, "PostulacionDetId", "Nombre");

            ViewBag.selectListPeriodo = selectListPeriodo;
            ViewBag.selectListOfertas = selectListOfertas;
            ViewBag.selectListProveedores = selectListProveedores;
            ViewBag.selectListPostulacionesDet = selectListPostulacionesDet;





            var configuracion = db.configuraciones.Single();

            CalculoCalificaciones calcCalif = new CalculoCalificaciones(configuracion);
            ViewBag.CalculoCalificaciones=calcCalif;

            return View(postulacion);
        }

        //Creacion de una nueva postulacion
        //Enviar a un formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
            

            return View();
        }

        //Grabar una postulacion
        [HttpPost]
        public IActionResult Create(Postulacion postulacion)
        {
            db.postulaciones.Add(postulacion);
            db.SaveChanges();

            TempData["mensaje"] = $"La postulacion {postulacion.PostulacionId} ha sido creada existosamente";

            return RedirectToAction("Index");
        }

        //Edicion de una postulacion
        //Enviar a un formulario con los datos de la postulacion seleccionada
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Postulacion postulacion = db.postulaciones.Find(id);
            return View(postulacion);
        }

        //Actualizar una postulacion
        [HttpPost]
        public IActionResult Edit(Postulacion postulacion)
        {
            db.postulaciones.Update(postulacion);
            db.SaveChanges();
            TempData["mensaje"] = $"La postulacion {postulacion.PostulacionId} ha sido actualizada existosamente";
            return RedirectToAction("Index");
        }

        //Borrar de una postulacion
        //Enviar a un formulario con los datos de la postulacion a eliminar
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Postulacion postulacion = db.postulaciones.Find(id);
            return View(postulacion);
        }

        //Eliminar una postulacion
        [HttpPost]
        public IActionResult Delete(Postulacion postulacion)
        {
            db.postulaciones.Remove(postulacion);
            db.SaveChanges();
            TempData["mensaje"] = $"La postulacion {postulacion.PostulacionId} ha sido eliminada existosamente";
            return RedirectToAction("Index");
        }
    }
}
