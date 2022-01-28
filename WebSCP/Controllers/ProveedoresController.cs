using Microsoft.AspNetCore.Mvc;
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
            IEnumerable<Proveedor> listaProveedores = db.proveedores;

            return View(listaProveedores);
        }

        //Creacion de una nuevo proveedor
        //Enviar a un formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
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
