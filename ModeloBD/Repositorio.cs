using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloBD
{
    public class Repositorio: DbContext
    {

        //Configuracion de las entidades
        public DbSet<Proveedor> proveedores { get; set; }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Oferta> ofertas { get; set; }
        public DbSet<Calificacion> calificaciones { get; set; }
        public DbSet<Configuracion> configuracion { get; set; }
        public DbSet<Periodo> periodos { get; set; }
        public DbSet<Postulacion> postulaciones { get; set; }
        public DbSet<Postulacion_Det> postulaciones_det { get; set; }

        //Configuracion de la conexion
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-975JAJB; Initial Catalog= SCP; trusted_connection=true;");
        }
    }
}
