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
    public class OfertasController : Controller
    {
        private readonly Repositorio db;
        public OfertasController(Repositorio db)
        {
            this.db = db;
        }

        //Recupera la lista de ofertas y envia hacia la vista
        public IActionResult Index()
        {
            IEnumerable<Oferta> listaOfertas = db.ofertas.Include(oferta=>oferta.Periodo);

            return View(listaOfertas);
        }

        //Creacion de una nueva oferta
        //Enviar a un formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
            //Listas
            
            
            var listaPeriodos = db.periodos
                .Select(periodo => new
                {
                    PeriodoId = periodo.PeriodoId,
                    Nombre = periodo.Nombre
                }).ToList();


            var listaPostulaciones = db.postulaciones
                .Select(postulacion => new
                {
                    PostulacionId = postulacion.PostulacionId,
                    Nombre = postulacion.Nombre
                }).ToList();

            var listaDetOferta = db.ofertas_det
                .Select(ofertas_det => new
                {
                    Oferta_DetId = ofertas_det.Oferta_DetId,
                    Nombre = ofertas_det.Nombre
                }).ToList();

            //Prepara las listas
            var selectListaPostulaciones = new SelectList(listaPostulaciones, "PostulacionId", "Nombre");
            var selectListPostulacionesDet = new SelectList(listaDetOferta, "PostulacionDetId", "Nombre");
            var selectListPeriodos = new SelectList(listaPeriodos, "PeriodoId", "Nombre");
           
            ViewBag.selectListaPostulaciones = selectListaPostulaciones;
            ViewBag.selectListPostulacionesDet = selectListPostulacionesDet;
            ViewBag.selectListPeriodos = selectListPeriodos;

            return View();
        }

        //Grabar una oferta
        [HttpPost]
        public IActionResult Create(Oferta oferta)
        {
            db.ofertas.Add(oferta);
            db.SaveChanges();
            
            TempData["mensaje"] = $"La oferta {oferta.OfertaId} ha sido creada existosamente";

            return RedirectToAction("Index");
        }

        //Edicion de una oferta
        //Enviar a un formulario con los datos de la oferta seleccionada
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Oferta oferta = db.ofertas.Find(id);
            return View(oferta);
        }

        //Actualizar una oferta
        [HttpPost]
        public IActionResult Edit(Oferta oferta)
        {
            db.ofertas.Update(oferta);
            db.SaveChanges();
            TempData["mensaje"] = $"La oferta {oferta.OfertaId} ha sido actualizada existosamente";
            return RedirectToAction("Index");
        }

        //Borrar de una oferta
        //Enviar a un formulario con los datos de la oferta a eliminar
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Oferta oferta = db.ofertas.Find(id);
            return View(oferta);
        }

        //Eliminar una oferta
        [HttpPost]
        public IActionResult Delete(Oferta oferta)
        {
            db.ofertas.Remove(oferta);
            db.SaveChanges();
            TempData["mensaje"] = $"La oferta {oferta.OfertaId} ha sido eliminada existosamente";
            return RedirectToAction("Index");
        }
    }
}
