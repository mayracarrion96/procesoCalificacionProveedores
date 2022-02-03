using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Modelo.Entidades;
using ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSCP.Controllers
{
    public class MarcaController : Controller
    {
        private readonly Repositorio db;
        public MarcaController(Repositorio db)
        {
            this.db = db;
        }

        //Recupera la lista de marcas y envia hacia la vista
        public IActionResult Index()
        {
            IEnumerable<Marca> listaMarcas= db.marcas;

            return View(listaMarcas);
        }

        //Creacion de una nueva marca
        //Enviar a un formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
            //Lista de postulacion_det
           var listaClasificaciones = db.clasificaciones
                .Select(clasificacion => new
                {
                    Nombre = clasificacion.Nombre
                }).ToList();

            //Prepara las listas
            var selectListClasificaciones = new SelectList(listaClasificaciones, "Nombre");

            
            ViewBag.selectListClasificaciones = selectListClasificaciones;
            return View();
        }

        //Grabar una marca
        [HttpPost]
        public IActionResult Create(Marca marca)
        {
            db.marcas.Add(marca);
            db.SaveChanges();

            TempData["mensaje"] = $"La marca {marca.Nombre} ha sido creada existosamente";

            return RedirectToAction("Index");
        }

        //Edicion de una marca
        //Enviar a un formulario con los datos de la marca seleccionada
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Marca marca = db.marcas.Find(id);
            return View(marca);
        }

        //Actualizar una marca
        [HttpPost]
        public IActionResult Edit(Marca marca)
        {
            db.marcas.Update(marca);
            db.SaveChanges();
            TempData["mensaje"] = $"La marca {marca.Nombre} ha sido actualizada existosamente";
            return RedirectToAction("Index");
        }

        //Borrar de una marca
        //Enviar a un formulario con los datos de la marca a eliminar
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Marca marca = db.marcas.Find(id);
            return View(marca);
        }

        //Eliminar una marca
        [HttpPost]
        public IActionResult Delete(Marca marca)
        {
            db.marcas.Remove(marca);
            db.SaveChanges();
            TempData["mensaje"] = $"La marca {marca.Nombre} ha sido eliminada existosamente";
            return RedirectToAction("Index");
        }
    }
}
