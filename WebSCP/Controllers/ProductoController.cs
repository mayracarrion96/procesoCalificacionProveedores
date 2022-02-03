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
    public class ProductoController : Controller
    {
        private readonly Repositorio db;
        public ProductoController(Repositorio db)
        {
            this.db = db;
        }

        //Recupera la lista de producto y envia hacia la vista
        public IActionResult Index()
        {
            IEnumerable<Producto> listaProductos = db.productos;

            return View(listaProductos);
        }

        //Creacion de una nuevo producto
        //Enviar a un formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
            //Lista
            
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

        //Grabar un producto
        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            db.productos.Add(producto);
            db.SaveChanges();

            TempData["mensaje"] = $"El producto {producto.Nombre} ha sido creado existosamente";

            return RedirectToAction("Index");
        }

        //Edicion de unproducto
        //Enviar a un formulario con los datos del producto seleccionado
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Producto producto = db.productos.Find(id);
            return View(producto);
        }

        //Actualizar el producto
        [HttpPost]
        public IActionResult Edit(Producto producto)
        {
            db.productos.Update(producto);
            db.SaveChanges();
            TempData["mensaje"] = $"El producto {producto.Nombre} ha sido actualizado existosamente";
            return RedirectToAction("Index");
        }

        //Borrar un producto
        //Enviar a un formulario con los datos del producto a eliminar
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Producto producto = db.productos.Find(id);
            return View(producto);
        }

        //Eliminar prodcuto
        [HttpPost]
        public IActionResult Delete(Producto producto)
        {
            db.productos.Remove(producto);
            db.SaveChanges();
            TempData["mensaje"] = $"El producto producto{producto.Nombre} ha sido eliminado existosamente";
            return RedirectToAction("Index");
        }
    }
}
