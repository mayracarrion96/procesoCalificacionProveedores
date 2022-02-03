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
    public class ClasificacionController : Controller
    {
        private readonly Repositorio db;
        public ClasificacionController(Repositorio db)
        {
            this.db = db;
        }

        //Recupera la lista de clasificacions y envia hacia la vista
        public IActionResult Index()
        {
            IEnumerable<Clasificacion> listaclasificacions = db.clasificaciones.Include(clasificacion=>clasificacion.Marca).Include(clasificacion => clasificacion.Producto);

            return View(listaclasificacions);
        }

        //Creacion de una nueva clasificacion
        //Enviar a un formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Grabar una clasificacion
        [HttpPost]
        public IActionResult Create(Clasificacion clasificacion)
        {
            db.clasificaciones.Add(clasificacion);
            db.SaveChanges();

            TempData["mensaje"] = "La clasificacion ha sido creada existosamente";

            return RedirectToAction("Index");
        }

        //Edicion de una clasificacion
        //Enviar a un formulario con los datos de la clasificacion seleccionada
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Clasificacion clasificacion = db.clasificaciones.Find(id);
            return View(clasificacion);
        }

        //Actualizar una clasificacion
        [HttpPost]
        public IActionResult Edit(Clasificacion clasificacion)
        {
            db.clasificaciones.Update(clasificacion);
            db.SaveChanges();
            TempData["mensaje"] = $"La clasificacion ha sido actualizada existosamente";
            return RedirectToAction("Index");
        }

        //Borrar de una clasificacion
        //Enviar a un formulario con los datos de la clasificacion a eliminar
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Clasificacion clasificacion = db.clasificaciones.Find(id);
            return View(clasificacion);
        }

        //Eliminar una clasificacion
        [HttpPost]
        public IActionResult Delete(Clasificacion clasificacion)
        {
            db.clasificaciones.Remove(clasificacion);
            db.SaveChanges();
            TempData["mensaje"] = $"La clasificacion ha sido eliminada existosamente";
            return RedirectToAction("Index");
        }
    }
}
