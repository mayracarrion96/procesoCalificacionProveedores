using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos
{
    public class ProValidacion
    {
        public Repositorio db { get; set; }
        public ProValidacion(Repositorio db)
        {
            this.db = db;
        }

        public bool Validacion(Postulacion postulaciones)
        {
            var temppostulacion = db.postulaciones
                .Include(postulacion => postulacion.Proveedor)
                .Include(postulacion => postulacion.Postulacion_Detalle)
                    .ThenInclude(postulacion_dets => postulacion_dets.Calificacion)


                .Single(postulacion => postulacion.PostulacionId == postulacion.PostulacionId)
                ;

           ProAprobaciones apro = new ProAprobaciones(db);
                       

            if (temppostulacion == null) return false;

            foreach (var post in temppostulacion.Postulacion_Detalle)
            {
                if (apro.Califico(temppostulacion.Proveedor, postulaciones))
                {
                    Console.WriteLine("  Aprobo: " + post.Nombre);
                    return true;
                }
                else
                {
                    Console.WriteLine("  No Aprobo: " + post.Nombre);
                    //return false;
                }
            }

            return false;
        }
    }
}
