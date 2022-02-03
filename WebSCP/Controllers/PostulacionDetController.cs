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
    public class PostulacionDetController : Controller
    {
        private readonly Repositorio db;
        public PostulacionDetController(Repositorio db)
        {
            this.db = db;
        }

        //Recupera la lista de postulacionDetes_det y envia hacia la vista
        public IActionResult Index()
        {
            IEnumerable<Postulacion_Det> listapostulacionDet = db.postulaciones_det.Include(postulacion_Det=>postulacion_Det.Calificacion);

            return View(listapostulacionDet);
        }

        //Creacion de una nueva postulacionDet
        //Enviar a un formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
            //Listas
            var listaPostulaciones = db.postulaciones
                .Select(postulacion => new
                {
                    PostulacionId = postulacion.PostulacionId,
                    Nombre = postulacion.Nombre
                }).ToList();

            var listaCalificaciones = db.calificaciones
                .Select(calificacion => new
                {
                    CalificacionId=calificacion.CalificacionId,
                    Nombre= calificacion.Nombre
                }).ToList();

            //Prepara las listas
            var selectListaPostulaciones = new SelectList(listaPostulaciones, "PostulacionId", "Nombre");
            var selectListaCalificaciones = new SelectList(listaCalificaciones, "CalificacionId", "Nombre");
            
            ViewBag.selectListaPostulaciones = selectListaPostulaciones;
            ViewBag.selectListaCalificaciones = selectListaCalificaciones;
            return View();
        }

        //Grabar una postulacionDet
        [HttpPost]
        public IActionResult Create(Postulacion_Det postulacionDet)
        {
            db.postulaciones_det.Add(postulacionDet);
            db.SaveChanges();

            TempData["mensaje"] = $"La postulacion detalle {postulacionDet.Postulacion_DetId} ha sido creada existosamente";

            return RedirectToAction("Index");
        }

        //Edicion de una postulacionDet
        //Enviar a un formulario con los datos de la postulacionDet seleccionada
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Postulacion_Det postulacionDet = db.postulaciones_det.Find(id);
            return View(postulacionDet);
        }

        //Actualizar una postulacionDet
        [HttpPost]
        public IActionResult Edit(Postulacion_Det postulacionDet)
        {
            db.postulaciones_det.Update(postulacionDet);
            db.SaveChanges();
            TempData["mensaje"] = $"La postulacion detalle {postulacionDet.Postulacion_DetId} ha sido actualizada existosamente";
            return RedirectToAction("Index");
        }

        //Borrar de una postulacionDet
        //Enviar a un formulario con los datos de la postulacionDet a eliminar
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Postulacion_Det postulacionDet = db.postulaciones_det.Find(id);
            return View(postulacionDet);
        }

        //Eliminar una postulacionDet
        [HttpPost]
        public IActionResult Delete(Postulacion_Det postulacionDet)
        {
            db.postulaciones_det.Remove(postulacionDet);
            db.SaveChanges();
            TempData["mensaje"] = $"La postulacion detalle {postulacionDet.Postulacion_DetId} ha sido eliminada existosamente";
            return RedirectToAction("Index");
        }
    }
}
