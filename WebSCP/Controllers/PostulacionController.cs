using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Modelo.Operaciones;
using ModeloBD;
using Procesos;
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
            IEnumerable<Postulacion> listaPostulacion = db.postulaciones
                .Include(postulacion => postulacion.Proveedor)
                .Include(postulacion => postulacion.Oferta)
                .Include(postulacion => postulacion.Periodo);

            return View(listaPostulacion);
        }

        //Pantalla para validacion de la matricula
        public IActionResult Validar(int id)
        {
           var postulacion =db.postulaciones
                .Include(postulacion => postulacion.Proveedor)
                .Include(postulacion => postulacion.Oferta)
                .Include(postulacion => postulacion.Periodo)
                .Include(postulacion => postulacion.Postulacion_Detalle)
                    .ThenInclude(postulacion_det => postulacion_det.Calificacion)
                .Single(postulacion => postulacion.PostulacionId==id)
                 ;

            //Listas
            var listaProveedor = db.proveedores
                .Select(proveedor => new
                {
                    ProveedorId = proveedor.ProveedorId,
                    Nombre = proveedor.Nombre
                }).ToList();

            var listaOferta = db.ofertas
                .Select(oferta => new
                {
                    OfertaId = oferta.OfertaId,
                    Nombre = oferta.Nombre
                }).ToList();

            var listaPeriodo = db.periodos
               .Select(periodo => new
               {
                   PeriodoId = periodo.PeriodoId,
                   Nombre = periodo.Nombre
               }).ToList();

            var listaDetPost = db.postulaciones_det
                .Select(postulacion_det => new
                {
                    Postulacion_DetId = postulacion_det.Postulacion_DetId,
                    Nombre = postulacion_det.Nombre
                }).ToList();

            //Prepara las listas
            var selectListPeriodo = new SelectList(listaPeriodo, "PeriodoId", "Nombre");
            var selectListOfertas = new SelectList(listaOferta, "OfertaId", "Nombre");
            var selectListProveedores = new SelectList(listaProveedor, "ProveedorId", "Nombre");
            var selectListPostulacionesDet = new SelectList(listaDetPost, "PostulacionDetId", "Nombre");

            ViewBag.selectListPeriodo = selectListPeriodo;
            ViewBag.selectListOfertas = selectListOfertas;
            ViewBag.selectListProveedores = selectListProveedores;
            ViewBag.selectListPostulacionesDet = selectListPostulacionesDet;





            var configuracion = db.configuraciones.Single();

            CalculoCalificaciones calcCalif = new CalculoCalificaciones(configuracion);
            ViewBag.CalculoCalificaciones=calcCalif;

            return View(postulacion);
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

           

        //Metodo para validar
        [HttpPost]
        public IActionResult Validar(Postulacion postulacion)
        {
            ProAprobaciones pro = new ProAprobaciones(db);
            var tmpPostulacion = db.postulaciones.Find(postulacion.PostulacionId);
            var tmpProveedor = db.proveedores.Find(postulacion.ProveedorId);

            if (pro.Califico(tmpProveedor, tmpPostulacion))
            {
                postulacion.Estado = PostulacionEstado.Aprobada;
                postulacion.Fecha = System.DateTime.Now;
                TempData["mensaje"] = $"La postulacion del proveedor {postulacion.Proveedor.Nombre} ha sido aprobado ";
            }
            else
            {
                postulacion.Estado = PostulacionEstado.Rechazada;
                postulacion.Fecha = System.DateTime.Now;
                TempData["mensaje"] = $"La postulacion del proveedor {postulacion.Proveedor.Nombre} ha sido rechazada ";
            }

            postulacion.Proveedor = null;
            postulacion.ProveedorId = tmpProveedor.ProveedorId;

            db.postulaciones.Update(postulacion);
            db.SaveChanges();
            TempData["mensaje"] = $"La postulacion {postulacion.PostulacionId} ha cambiado de estado existosamente";
            return RedirectToAction("Index");

        }
        }
}
