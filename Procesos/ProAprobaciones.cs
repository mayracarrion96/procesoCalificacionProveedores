using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Modelo.Operaciones;
using ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos
{
    public class ProAprobaciones
    {
        public Repositorio db { get; set; }
        public ProAprobaciones(Repositorio db)
        {
            this.db = db;
        }

        public bool Califico(Proveedor proveedor, Postulacion postulacion)
        {
            var tmpProveedor = db.proveedores
                .Include(prov => prov.Postulacion)
                    .ThenInclude(post => post.Postulacion_Detalle)
                        .ThenInclude(det => det.Calificacion)

                .Single(prov => prov.ProveedorId == proveedor.ProveedorId)
                ;

            var configuracion = db.configuraciones.Single();

            CalculoCalificaciones calc = new CalculoCalificaciones(configuracion);


            foreach (var post in tmpProveedor.Postulacion)
            {
                foreach (var det in post.Postulacion_Detalle)
                {

                    if (det.Calificacion != null)
                    {
                        if (calc.Aprobado(det.Calificacion))
                        {
                            return true;

                        }
                    }


                }
            }
            return false;
        }
    }
}
