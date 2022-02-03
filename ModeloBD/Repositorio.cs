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
        public Repositorio()
        {


        }
        
        //PARA CUANDO UTILICE NUESTRO PROYECTO WEB, AÑADIMOS UN CONSTRUCTOR
        public Repositorio(DbContextOptions<Repositorio> options)
            :base(options)
        {

        }

        // Se asegura el borrado y la creación de la base de datos
        public void PreparaDB()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        //Configuracion de las entidades
        public DbSet<Proveedor> proveedores { get; set; }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Marca> marcas { get; set; }
        public DbSet<Clasificacion> clasificaciones { get; set; }
        public DbSet<Oferta> ofertas { get; set; }
        public DbSet<Oferta_Det> ofertas_det { get; set; }
        public DbSet<Calificacion> calificaciones { get; set; }
        public DbSet<Configuracion> configuraciones { get; set; }
        public DbSet<Periodo> periodos { get; set; }
        public DbSet<Postulacion> postulaciones { get; set; }
        public DbSet<Postulacion_Det> postulaciones_det { get; set; }

        //Configuracion de la conexion

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Si no se ha configurado la conección la configura con SqlServer
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-975JAJB; Initial Catalog= SCP; trusted_connection=true;");

            }
        }

        //Configurar el modelo de objetos
        protected override void OnModelCreating (ModelBuilder model)
        {
            //Relacion de de uno a muchos
            //un proveedor va a tener varias postulaciones
            model.Entity<Postulacion>()
                .HasOne(postulacion => postulacion.Proveedor)
                .WithMany(proveedor => proveedor.Postulacion)
                .HasForeignKey(postulacion => postulacion.ProveedorId);

            //un periodo va a tener varias postulaciones
            model.Entity<Postulacion>()
                .HasOne(postulacion => postulacion.Periodo)
                .WithMany(periodo => periodo.Postulacion)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(postulacion => postulacion.PeriodoId);

            //una oferta va a tener varias postulaciones
            model.Entity<Postulacion>()
                .HasOne(postulacion => postulacion.Oferta)
                .WithMany(oferta => oferta.Postulacion)
                .HasForeignKey(postulacion => postulacion.OfertaId);

            //un periodo va a tener varias ofertas
            model.Entity<Oferta>()
                .HasOne(oferta => oferta.Periodo)
                .WithMany(periodo => periodo.Oferta)
                .HasForeignKey(oferta => oferta.PeriodoId);

            //una oferta va a tener varios detalle de oferta
            model.Entity<Oferta_Det>()
                .HasOne(oferta_det => oferta_det.Oferta)
                .WithMany(oferta => oferta.Oferta_Det)
                .HasForeignKey(oferta_det => oferta_det.OfertaId);

            //una postulacion va a tener varios detalle de postulacion
            model.Entity<Postulacion_Det>()
                .HasOne(postulacion_det => postulacion_det.Postulacion)
                .WithMany(postulacion => postulacion.Postulacion_Detalle)
                .HasForeignKey(postulacion_det => postulacion_det.PostulacionId);

            //un producto va a estar en varias ofertas_detalles
            model.Entity<Oferta_Det>()
                .HasOne(oferta_det => oferta_det.Producto)
                .WithMany(producto => producto.Oferta_Det)
                .HasForeignKey(oferta_det => oferta_det.ProductoId);

            //Relacion de uno a uno
            //una postulacion_det va a tener una calificacion
            model.Entity<Postulacion_Det>()
                .HasOne(postulacion_det => postulacion_det.Calificacion)
                .WithOne(calificacion => calificacion.Postulacion_Det)
                .HasForeignKey<Calificacion>(calificacion => calificacion.Postulacion_DetId);

            
            //Configuracion
            //La clase configuracion no tiene clave primaria
            //model.Entity<Configuracion>()
              //  .HasNoKey();

            //un periodo y una solo configuracion
            model.Entity<Configuracion>()
                .HasOne(configuracion => configuracion.PeriodoVigente)
                .WithOne()
                .HasForeignKey<Configuracion>(configuracion => configuracion.PeriodoVigenteId);


            //Relacion de muchos a muchos
            model.Entity<Clasificacion>()
                .HasKey(clasificacion => new { clasificacion.MarcaId, clasificacion.ProductoId });

            model.Entity<Clasificacion>()
                .HasOne(clasificacion => clasificacion.Marca)
                .WithMany(marca => marca.Clasificacion)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(clasificacion => clasificacion.MarcaId);

            model.Entity<Clasificacion>()
                .HasOne(clasificacion => clasificacion.Producto)
                .WithMany(producto => producto.Clasificacion)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(clasificacion => clasificacion.ProductoId);

            

        }
    }
}
