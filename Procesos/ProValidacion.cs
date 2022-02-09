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

        public bool Validacion(Proveedor proveedor, Postulacion postulacion)
        {

            ProAprobaciones apro = new ProAprobaciones(db);

            if (apro.Califico(proveedor, postulacion))
            {
                return true;
            }
            
            return false;
            
        }
    }
}
