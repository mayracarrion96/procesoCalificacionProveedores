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
    public class ProveedoresController : Controller
    {
        private readonly Repositorio db;
        public ProveedoresController(Repositorio db)
        {
            this.db = db;
        }

        //Recupera la lista de proveedores y envia hacia la vista
        public IActionResult Index()
        {
            IEnumerable<Proveedor> listaProveedores = db.proveedores
                .Include(proveedor => proveedor.Postulacion);

            return View(listaProveedores);
        }

        //Creacion de una nuevo proveedor
        //Enviar a un formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
            //Lista de postulacion
            var listaPostulaciones = db.postulaciones
                .Select(postulacion => new
                {
                    PostulacionId = postulacion.PostulacionId,
                    Nombre = postulacion.Nombre
                }).ToList();

            //Prepara las listas
            var selectListaPostulaciones = new SelectList(listaPostulaciones, "PostulacionId", "Nombre");

            ViewBag.selectListaPostulaciones = selectListaPostulaciones;

            return View();
        }

        //Grabar un proveedor
        [HttpPost]
        public IActionResult Create(Proveedor proveedor)
        {
            db.proveedores.Add(proveedor);
            db.SaveChanges();

            TempData["mensaje"] = $"El proveedor {proveedor.Nombre} ha sido creado existosamente";

            return RedirectToAction("Index");
        }

        //Edicion de un proveedor
        //Enviar a un formulario con los datos del proveedor seleccionado
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Proveedor proveedor = db.proveedores.Find(id);
            return View(proveedor);
        }

        //Actualizar el proveedor
        [HttpPost]
        public IActionResult Edit(Proveedor proveedor)
        {
            db.proveedores.Update(proveedor);
            db.SaveChanges();
            TempData["mensaje"] = $"El proveedor {proveedor.Nombre} ha sido actualizado existosamente";
            return RedirectToAction("Index");
        }

        //Borrar un proveedor
        //Enviar a un formulario con los datos del proveedor a eliminar
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Proveedor proveedor = db.proveedores.Find(id);
            return View(proveedor);
        }

        //Eliminar prodcuto
        [HttpPost]
        public IActionResult Delete(Proveedor proveedor)
        {
            db.proveedores.Remove(proveedor);
            db.SaveChanges();
            TempData["mensaje"] = $"El proveedor proveedor{proveedor.Nombre} ha sido eliminado existosamente";
            return RedirectToAction("Index");
        }
    }
}
