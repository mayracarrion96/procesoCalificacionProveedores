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
    public class ConfiguracionController : Controller
    {
        private readonly Repositorio db;
        public ConfiguracionController(Repositorio db)
        {
            this.db = db;
        }

        //Recupera la lista de configuracions y envia hacia la vista
        public IActionResult Index()
        {
            IEnumerable<Configuracion> listaconfiguracions = db.configuraciones.Include(configuracion => configuracion.PeriodoVigente);

            return View(listaconfiguracions);
        }

        //Creacion de una nueva configuracion
        //Enviar a un formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Grabar una configuracion
        [HttpPost]
        public IActionResult Create(Configuracion configuracion)
        {
            db.configuraciones.Add(configuracion);
            db.SaveChanges();

            TempData["mensaje"] = "La configuracion ha sido creada existosamente";

            return RedirectToAction("Index");
        }

        //Edicion de una configuracion
        //Enviar a un formulario con los datos de la configuracion seleccionada
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Configuracion configuracion = db.configuraciones.Find(id);
            return View(configuracion);
        }

        //Actualizar una configuracion
        [HttpPost]
        public IActionResult Edit(Configuracion configuracion)
        {
            db.configuraciones.Update(configuracion);
            db.SaveChanges();
            TempData["mensaje"] = $"La configuracion ha sido actualizada existosamente";
            return RedirectToAction("Index");
        }

        //Borrar de una configuracion
        //Enviar a un formulario con los datos de la configuracion a eliminar
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Configuracion configuracion = db.configuraciones.Find(id);
            return View(configuracion);
        }

        //Eliminar una configuracion
        [HttpPost]
        public IActionResult Delete(Configuracion configuracion)
        {
            db.configuraciones.Remove(configuracion);
            db.SaveChanges();
            TempData["mensaje"] = $"La configuracion ha sido eliminada existosamente";
            return RedirectToAction("Index");
        }
    }
}
