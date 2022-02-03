using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSCP.Controllers
{
    public class CalificacionController : Controller
    {
        private readonly Repositorio db;
        public CalificacionController(Repositorio db)
        {
            this.db = db;
        }

        //Recupera la lista de calificaciones y envia hacia la vista
        public IActionResult Index()
        {
            IEnumerable<Calificacion> listaCalificaciones = db.calificaciones
                .Include(calificacion=>calificacion.Postulacion_Det);

            return View(listaCalificaciones);
        }

        //Creacion de una nueva calificacion
        //Enviar a un formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
            //Listas
           var listaDetPost = db.postulaciones_det
                .Select(postulacion_det => new
                {
                    Postulacion_DetId = postulacion_det.Postulacion_DetId,
                    Nombre = postulacion_det.Nombre
                }).ToList();

            //Prepara las listas
           
            var selectListPostulacionesDet = new SelectList(listaDetPost, "PostulacionDetId", "Nombre");

           ViewBag.selectListPostulacionDet = selectListPostulacionesDet;

            return View();
        }

        //Grabar una calificacion
        [HttpPost]
        public IActionResult Create(Calificacion calificacion)
        {
            db.calificaciones.Add(calificacion);
            db.SaveChanges();

            TempData["mensaje"] = $"La calificacion {calificacion.CalificacionId} ha sido creada existosamente";

            return RedirectToAction("Index");
        }

        //Edicion de una calificacion
        //Enviar a un formulario con los datos de la calificacion seleccionada
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Calificacion calificacion = db.calificaciones.Find(id);
            return View(calificacion);
        }

        //Actualizar una calificacion
        [HttpPost]
        public IActionResult Edit(Calificacion calificacion)
        {
            db.calificaciones.Update(calificacion);
            db.SaveChanges();
            TempData["mensaje"] = $"La calificacion {calificacion.CalificacionId} ha sido actualizada existosamente";
            return RedirectToAction("Index");
        }

        //Borrar de una calificacion
        //Enviar a un formulario con los datos de la calificacion a eliminar
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Calificacion calificacion = db.calificaciones.Find(id);
            return View(calificacion);
        }

        //Eliminar una calificacion
        [HttpPost]
        public IActionResult Delete(Calificacion calificacion)
        {
            db.calificaciones.Remove(calificacion);
            db.SaveChanges();
            TempData["mensaje"] = $"La calificacion {calificacion.CalificacionId} ha sido eliminada existosamente";
            return RedirectToAction("Index");
        }
    }
}
