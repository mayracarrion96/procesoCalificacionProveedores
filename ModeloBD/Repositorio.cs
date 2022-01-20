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
        


        //Configurar el modelo de objetos
        protected override void OnModelCreating (ModelBuilder model)
        {
            //configuracion de postulacion, de uno a muchos
            //postulacion y proveedor
            model.Entity<Postulacion>()
                .HasOne(postulacion => postulacion.Proveedor)
                .WithMany(proveedor => proveedor.Postulacion)
                .HasForeignKey(postulacion => postulacion.ProveedorId);

            //postulacion y periodo
            model.Entity<Postulacion>()
                .HasOne(postulacion => postulacion.Periodo)
                .WithMany(periodo => periodo.Postulacion)
                .HasForeignKey(postulacion => postulacion.PeriodoId);

            
            //Configuracion de postulaciones_det, de uno a uno
            //postulacion_det con calificacion
            model.Entity<Postulacion_Det>()
                .HasOne(postulacion_det => postulacion_det.Calificacion)
                .WithOne(calificacion => calificacion.Postulacion_Det)
                .HasForeignKey<Calificacion>(calificacion => calificacion.Postulacion_DetId);

            //Configuracion
            //La clase configuracion no tiene clave primaria
            model.Entity<Configuracion>()
                .HasNoKey();

        }
    }
}
