using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
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
            IEnumerable<Postulacion> listaPostulacion = db.postulaciones.Include(postulacion => postulacion.Proveedor);

            return View(listaPostulacion);
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
