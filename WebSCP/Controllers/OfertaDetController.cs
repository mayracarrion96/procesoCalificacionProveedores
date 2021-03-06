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
    public class OfertaDetController : Controller
    {
        private readonly Repositorio db;
        public OfertaDetController(Repositorio db)
        {
            this.db = db;
        }

        //Recupera la lista de ofertaDets_det y envia hacia la vista
        public IActionResult Index()
        {
            IEnumerable<Oferta_Det> listaofertaDet = db.ofertas_det.Include(oferta_Det=>oferta_Det.Oferta).Include(oferta_Det => oferta_Det.Producto);

            return View(listaofertaDet);
        }

        //Creacion de una nueva ofertaDet
        //Enviar a un formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
            //Listas
            var listaOferta = db.ofertas
                .Select(oferta => new
                {
                    OfertaId = oferta.OfertaId,
                    Nombre = oferta.Nombre
                }).ToList();

            var listaProductos = db.productos
                .Select(productos => new
                {
                    ProductoId = productos.ProductoId,
                    Nombre = productos.Nombre
                }).ToList();


            //Prepara las listas
            var selectListaProductos = new SelectList(listaProductos, "ProductoId", "Nombre");
            var selectListOfertas = new SelectList(listaOferta, "OfertaId", "Nombre");

            ViewBag.selectListaProductos = selectListaProductos;
            ViewBag.selectListOfertas = selectListOfertas;

            return View();
        }

        //Grabar una ofertaDet
        [HttpPost]
        public IActionResult Create(Oferta_Det ofertaDet)
        {
            db.ofertas_det.Add(ofertaDet);
            db.SaveChanges();

            TempData["mensaje"] = $"La oferta detalle {ofertaDet.Oferta_DetId} ha sido creada existosamente";

            return RedirectToAction("Index");
        }

        //Edicion de una ofertaDet
        //Enviar a un formulario con los datos de la ofertaDet seleccionada
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Oferta_Det ofertaDet = db.ofertas_det.Find(id);
            return View(ofertaDet);
        }

        //Actualizar una ofertaDet
        [HttpPost]
        public IActionResult Edit(Oferta_Det ofertaDet)
        {
            db.ofertas_det.Update(ofertaDet);
            db.SaveChanges();
            TempData["mensaje"] = $"La oferta detalle {ofertaDet.Oferta_DetId} ha sido actualizada existosamente";
            return RedirectToAction("Index");
        }

        //Borrar de una ofertaDet
        //Enviar a un formulario con los datos de la ofertaDet a eliminar
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Oferta_Det ofertaDet = db.ofertas_det.Find(id);
            return View(ofertaDet);
        }

        //Eliminar una ofertaDet
        [HttpPost]
        public IActionResult Delete(Oferta_Det ofertaDet)
        {
            db.ofertas_det.Remove(ofertaDet);
            db.SaveChanges();
            TempData["mensaje"] = $"La oferta detalle {ofertaDet.Oferta_DetId} ha sido eliminada existosamente";
            return RedirectToAction("Index");
        }
    }
}
