using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSCP.Controllers
{
    public class PeriodoController : Controller
    {
        private readonly Repositorio db;
        public PeriodoController(Repositorio db)
        {
            this.db = db;
        }

        //Recupera la lista de periodo y envia hacia la vista
        public IActionResult Index()
        {
            IEnumerable<Periodo> listaPeriodos = db.periodos;

            return View(listaPeriodos);
        }

        //Creacion de una nuevo periodo
        //Enviar a un formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Grabar un periodo
        [HttpPost]
        public IActionResult Create(Periodo periodo)
        {
            db.periodos.Add(periodo);
            db.SaveChanges();

            TempData["mensaje"] = $"El periodo {periodo.PeriodoId} ha sido creado existosamente";

            return RedirectToAction("Index");
        }

        //Edicion de unperiodo
        //Enviar a un formulario con los datos del periodo seleccionado
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Periodo periodo = db.periodos.Find(id);
            return View(periodo);
        }

        //Actualizar el periodo
        [HttpPost]
        public IActionResult Edit(Periodo periodo)
        {
            db.periodos.Update(periodo);
            db.SaveChanges();
            TempData["mensaje"] = $"El periodo {periodo.PeriodoId} ha sido actualizado existosamente";
            return RedirectToAction("Index");
        }

        //Borrar un periodo
        //Enviar a un formulario con los datos del periodo a eliminar
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Periodo periodo = db.periodos.Find(id);
            return View(periodo);
        }

        //Eliminar prodcuto
        [HttpPost]
        public IActionResult Delete(Periodo periodo)
        {
            db.periodos.Remove(periodo);
            db.SaveChanges();
            TempData["mensaje"] = $"El periodo {periodo.PeriodoId} ha sido eliminado existosamente";
            return RedirectToAction("Index");
        }
    }
}
