using Modelo.Entidades;
using ModeloBD;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Proveedores
            Proveedor Dismap = new Proveedor()
            {
                Nombre = "Dismap S.A.",
                Ruc = "1709451221001",
                Direccion = "Francisco de Orellana E3-16",
                Telefono = "3530324",
                Correo = "ventas@dismap.com"

            };
            Proveedor Onerom = new Proveedor()
            {
                Nombre = "Onerom CIA. LTDA.",
                Ruc = "1792645379001",
                Direccion = "Polonia N31-92",
                Telefono = "2548210",
                Correo = "ventas@onerom.com"

            };
            Proveedor Ecuaempaques = new Proveedor()
            {
                Nombre = "Ecuaempaques S.A.",
                Ruc = "1791350529001",
                Direccion = "Isacc Albeniz E5-101",
                Telefono = "2812860",
                Correo = "facturacion@ecuaempaques.com"

            };
            Proveedor Vicents = new Proveedor()
            {
                Nombre = "Vicents S.A.",
                Ruc = "1705934766001",
                Direccion = "Pasaje A- n47-48",
                Telefono = "3318760",
                Correo = "facturas@vicents.com"

            };
            Proveedor Siglo = new Proveedor()
            {
                Nombre = "Siglo21 CIA. LTDA.",
                Ruc = "0991243844001",
                Direccion = "Condor OE-32 y Edmundo",
                Telefono = "3732121",
                Correo = "soporteonline@siglo21.net"

            };
            Proveedor Dilipa = new Proveedor()
            {
                Nombre = "Dilipa CIA. LTDA.",
                Ruc = "1790819515001",
                Direccion = "Av. 10 de agosto N52-15",
                Telefono = "2226402",
                Correo = "ventas@dilipa.com"

            };
            Proveedor Ofi = new Proveedor()
            {
                Nombre = "Ofi Expres S.A",
                Ruc = "1717486862001",
                Direccion = "Av. 10 de agosto N24-118",
                Telefono = "5103552",
                Correo = "ofiexpress1981@gmail.com"

            };
            Proveedor Ecolors = new Proveedor()
            {
                Nombre = "Ecolors S.A.",
                Ruc = "1715137749001",
                Direccion = "Avenida Oriental Lote 36",
                Telefono = "0987505556",
                Correo = "gabriel_47cartagena@hotmail.com"

            };
            Proveedor Compupaper = new Proveedor()
            {
                Nombre = "Compupaper CIA. LTDA.",
                Ruc = "0923346647001",
                Direccion = "Ulloa N21-23 y San Gregorio",
                Telefono = "3410385",
                Correo = "cpaper@compupaper.com.ec"
            };
            Proveedor Budak = new Proveedor()
            {
                Nombre = "Budak S.A.",
                Ruc = "1792348137001",
                Direccion = "Orellana L-198 y Hernando de Magallanes",
                Telefono = "2836008",
                Correo = "budak@corporacionbudak.com.ec"
            };
            Proveedor Leo = new Proveedor()
            {
                Nombre = "Distribuidora Leo S.A.",
                Ruc = "1701415992001",
                Direccion = "Jeronimo Carrion OE3-32 y Versalles",
                Telefono = "2229723",
                Correo = "ventas@distribuidoraleo.com"
            };
            Proveedor Santos = new Proveedor()
            {
                Nombre = "Santos Distribuidores S.A.",
                Ruc = "1711787174001",
                Direccion = "La Mariscal, Inglaterra E3-58",
                Telefono = "2220795",
                Correo = "fact@santos.com"
            };
            Proveedor JYE = new Proveedor()
            {
                Nombre = "JYE Fabricantes S.A.",
                Ruc = "1707724959001",
                Direccion = "Hierba Buena 2 Oriente Quiteño",
                Telefono = "677585",
                Correo = "jyefabricantes@hotmail.com"
            };
            Proveedor Balmer = new Proveedor()
            {
                Nombre = "Balmer Imports S.A.",
                Ruc = "17919952201001",
                Direccion = "A. 6 de diciembre E10-264",
                Telefono = "242182",
                Correo = "balmerimport@gmail.com"
            };
            Proveedor SYS = new Proveedor()
            {
                Nombre = "SyS S.A.",
                Ruc = "1900079789001",
                Direccion = "Conocoto",
                Telefono = "2070065",
                Correo = "rosagonzalec@yahoo.com"
            };

            List<Proveedor> listaproveedores = new List<Proveedor>() {
                Dismap, Onerom, Ecuaempaques, Vicents, Siglo, Dilipa,
                Ofi, Ecolors, Compupaper, Budak, Leo, Santos, JYE,
                Balmer, SYS };
            
            //Marca
            Marca Pelikan = new Marca()
            {
                Nombre = "Pelikan"
            };
            Marca Superior = new Marca()
            {
                Nombre = "Superior"
            };
            Marca BIC = new Marca()
            {
                Nombre = "BIC"
            };
            Marca Xerox = new Marca()
            {
                Nombre = "Xerox"
            };
            Marca Genius = new Marca()
            {
                Nombre = "Genius"
            };
            Marca Artesco = new Marca()
            {
                Nombre = "Artesco"
            };
            Marca Jeff = new Marca()
            {
                Nombre = "Jeff"
            };
            Marca Lancer = new Marca()
            {
                Nombre = "Lancer"
            };

            List<Marca> listamarcas = new List<Marca>() {
                Pelikan, Superior, BIC, Lancer, Jeff, Artesco, Genius, Xerox };
           

            //Periodos
            Periodo Periodo_2019 = new Periodo()
            {
                FechaInicio = new DateTime(2019, 01, 01),
                FechaFin = new DateTime(2019, 12, 31),
                Estado = "Terminado"
            };
            Periodo Periodo_2020 = new Periodo()
            {
                FechaInicio = new DateTime(2020, 01, 01),
                FechaFin = new DateTime(2020, 12, 31),
                Estado = "Terminado"
            };
            Periodo Periodo_2021 = new Periodo()
            {
                FechaInicio = new DateTime(2021, 01, 01),
                FechaFin = new DateTime(2021, 12, 31),
                Estado = "Terminado"
            };
            Periodo Periodo_2022 = new Periodo()
            {
                FechaInicio = new DateTime(2022, 01, 01),
                FechaFin = new DateTime(2022, 12, 31),
                Estado = "Pendiente"
            };

            List<Periodo> listaperiodos = new List<Periodo>() {
                Periodo_2019, Periodo_2020, Periodo_2021, Periodo_2022 };

            // Productos
            Producto Marcador = new Producto()
            {
                Nombre = "Marcador cd doble punto",
                Unidad = "unidad"

            };
            Producto Rollo = new Producto()
            {
                Nombre = "Rollo termico",
                Unidad = "unidad"
            };
            Producto Auricular = new Producto()
            {
                Nombre = "Auricular Genius HS-04S",
                Unidad = "unidad"
            };
            Producto BoligrafoPM = new Producto()
            {
                Nombre = "Boligrafo punta media",
                Unidad = "unidad"
            };
            Producto BoligradoPF = new Producto()
            {
                Nombre = "Boligrafo punta fina",
                Unidad = "unidad"
            };
            Producto Cartucho = new Producto()
            {
                Nombre = "Cartucho HP 954XL",
                Unidad = "unidad"
            };
            Producto CD = new Producto()
            {
                Nombre = "CD-RW 80min",
                Unidad = "PAQ X20"
            };
            Producto Tintas = new Producto()
            {
                Nombre = "Juego de Tintas 544",
                Unidad = "PAQ X3"
            };
            Producto Calculadora = new Producto()
            {
                Nombre = "Calculadora Casio MX-12B-BK",
                Unidad = "unidad"
            };
            Producto Papelera = new Producto()
            {
                Nombre = "Papelera metalica 2 servicios",
                Unidad = "unidad"
            };
            Producto MarcadorPerm = new Producto()
            {
                Nombre = "Marcador permanente E-800",
                Unidad = "unidad"
            };
            Producto MarcadorTiza = new Producto()
            {
                Nombre = "Marcador 426 tiza liquida",
                Unidad = "unidad"
            };
            Producto Camara = new Producto()
            {
                Nombre = "Camara web genius negra hd",
                Unidad = "unidad"
            };
            Producto Resma = new Producto()
            {
                Nombre = "Resma de papel bond A4",
                Unidad = "unidad"
            };
            Producto Papel = new Producto()
            {
                Nombre = "Caja de papel bond",
                Unidad = "PAQ X10"
            };
            Producto Fundas = new Producto()
            {
                Nombre = "Fundas naturales 14x20",
                Unidad = "PAQ X50"
            };
            Producto Cinta = new Producto()
            {
                Nombre = "Cinta adhesiva abro magica 18x25",
                Unidad = "unidad"
            };
            Producto Silicon = new Producto()
            {
                Nombre = "Silicon liquido 100 ml",
                Unidad = "unidad"
            };
            Producto Archivador = new Producto()
            {
                Nombre = "Archivador pasivo #15",
                Unidad = "unidad"
            };
            Producto Etiqueta = new Producto()
            {
                Nombre = "Etiqueta adhesiva T-7 ",
                Unidad = "PAQ X100"
            };
            Producto Libreta = new Producto()
            {
                Nombre = "Libreta #1 cuadros",
                Unidad = "unidad"
            };
            Producto Hojas = new Producto()
            {
                Nombre = "Hojas adhesivas A4",
                Unidad = "PAQ X100"
            };
            Producto Estilete = new Producto()
            {
                Nombre = "Estilete reforzado",
                Unidad = "unidad"
            };
            Producto Borrador = new Producto()
            {
                Nombre = "Borrador PZ-20",
                Unidad = "unidad"
            };
            Producto Clips = new Producto()
            {
                Nombre = "Clips mariposa alex",
                Unidad = "PAQ X50"
            };

            List<Producto> listaproductos = new List<Producto>() {
                Marcador, Rollo, Auricular, BoligradoPF, BoligrafoPM, Cartucho, CD, Tintas, Calculadora,
                Papelera, MarcadorPerm, MarcadorTiza, Camara, Resma, Papel, Papelera, Clips, Borrador,
                Archivador, Silicon, Cinta, Fundas,  Estilete, Hojas, Libreta, Etiqueta};

            //Clasificacion
            Clasificacion Clasif1 = new Clasificacion()
            {
                Marca = Pelikan,
                Producto = MarcadorPerm
            };

            //Ofertas
            Oferta OfertaDismap = new Oferta()
            {
                ScoreBuro = 960,
                Periodo = Periodo_2021,
            };

            //Oferta_Det
            Oferta_Det OfertaDetDismap = new Oferta_Det()
            {
                Oferta = OfertaDismap,
                Producto= Tintas,
                Precio = (decimal)12.00f,
                LoteMinimo = 400,
                Descuento = 10,
                Garantia = true,
                TiempoEntrega = 3
            };

            //Postulacion
            Postulacion PostDismap_2021 = new Postulacion()
            {
                Estado = "Pendiente",
                Fecha = new DateTime(2021, 2, 1),
                Proveedor = Dismap,
                Oferta = OfertaDismap,
                Periodo = Periodo_2021

            };
            
            Postulacion PostOnerom_2021 = new Postulacion()
            {
                Estado = "Pendiente",
                Fecha = new DateTime(2021, 2, 1),
                Proveedor = Onerom,
                Periodo = Periodo_2021
            };
            Postulacion PostEcuampaques_2021 = new Postulacion()
            {
                Estado = "Pendiente",
                Fecha = new DateTime(2021, 2, 1),
                Proveedor = Ecuaempaques,
                Periodo = Periodo_2021
            };
            Postulacion PostVicents_2021 = new Postulacion()
            {
                Estado = "Pendiente",
                Fecha = new DateTime(2021, 2, 2),
                Proveedor = Vicents,
                Periodo = Periodo_2021
            };
            Postulacion PostSiglo_2021 = new Postulacion()
            {
                Estado = "Pendiente",
                Fecha = new DateTime(2021, 2, 2),
                Proveedor = Siglo,
                Periodo = Periodo_2021
            };
            Postulacion PostDilipa_2021 = new Postulacion()
            {
                Estado = "Pendiente",
                Fecha = new DateTime(2021, 2, 2),
                Proveedor = Dilipa,
                Periodo = Periodo_2021
            };
            Postulacion PostOfi_2021 = new Postulacion()
            {
                Estado = "Pendiente",
                Fecha = new DateTime(2021, 2, 3),
                Proveedor = Ofi,
                Periodo = Periodo_2021
            };
            Postulacion PostEcolors_2021 = new Postulacion()
            {
                Estado = "Pendiente",
                Fecha = new DateTime(2021, 2, 3),
                Proveedor = Ecolors,
                Periodo = Periodo_2021
            };
            Postulacion PostCompupaper_2021 = new Postulacion()
            {
                Estado = "Pendiente",
                Fecha = new DateTime(2021, 2, 3),
                Proveedor = Compupaper,
                Periodo = Periodo_2021
            };
            Postulacion PostBudak_2021 = new Postulacion()
            {
                Estado = "Pendiente",
                Fecha = new DateTime(2021, 2, 4),
                Proveedor = Budak,
                Periodo = Periodo_2021
            };
            Postulacion PostLeo_2021 = new Postulacion()
            {
                Estado = "Pendiente",
                Fecha = new DateTime(2021, 2, 4),
                Proveedor = Leo,
                Periodo = Periodo_2021
            };
            Postulacion PostSantos_2021 = new Postulacion()
            {
                Estado = "Pendiente",
                Fecha = new DateTime(2021, 2, 4),
                Proveedor = Santos,
                Periodo = Periodo_2021
            };
            Postulacion PostJYE_2021 = new Postulacion()
            {
                Estado = "Pendiente",
                Fecha = new DateTime(2021, 2, 5),
                Proveedor = JYE,
                Periodo = Periodo_2021
            };
            Postulacion PostBalmer_2021 = new Postulacion()
            {
                Estado = "Pendiente",
                Fecha = new DateTime(2021, 2, 5),
                Proveedor = Balmer,
                Periodo = Periodo_2021
            };
            Postulacion PostSYS_2021 = new Postulacion()
            {
                Estado = "Pendiente",
                Fecha = new DateTime(2021, 2, 3),
                Proveedor = SYS,
                Periodo = Periodo_2021
            };

            List<Postulacion> listapostulaciones = new List<Postulacion>() {
                PostBalmer_2021, PostBudak_2021, PostCompupaper_2021, PostDilipa_2021,
                PostDismap_2021, PostEcolors_2021, PostEcuampaques_2021, PostJYE_2021,  PostLeo_2021,
                PostOfi_2021, PostOnerom_2021, PostSantos_2021, PostSiglo_2021, PostSYS_2021, PostVicents_2021};
            

            //Calificacion

            Calificacion CalifDismap = new Calificacion()
            {
                Nota1 = 5.0f,
                Nota2 = 5.0f,
                Nota3 = 5.0f,
                Nota4 = 5.0f,
                Nota5 = 5.0f,
                Nota6 = 5.0f,
                Nota7 = 5.0f,
            };

            //Postulacion_Det
            Postulacion_Det PostDetDismap_2021 = new Postulacion_Det()
            {
                Postulacion = PostDismap_2021,
                Calificacion = CalifDismap

            };
            
            //Configuracion
            /*
            Configuracion configuracion = new Configuracion()
            {
                NotaMinima = 15.1f,
                PesoNota1 = 0.05f,
                PesoNota2 = 0.20f,
                PesoNota3 = 0.15f,
                PesoNota4 = 0.20f,
                PesoNota5 = 0.15f,
                PesoNota6 = 0.15f,
                PesoNota7 = 0.10f
                //PeriodoVigente=Periodo_2022,
            };
            */
            
            Repositorio db = new Repositorio();
            db.proveedores.AddRange(listaproveedores);
            db.marcas.AddRange(listamarcas);
            db.periodos.AddRange(listaperiodos);
            db.productos.AddRange(listaproductos);
            db.clasificaciones.Add(Clasif1);
            db.ofertas.Add(OfertaDismap);
            db.ofertas_det.Add(OfertaDetDismap);
            db.postulaciones.AddRange(PostDismap_2021);
            db.postulaciones_det.Add(PostDetDismap_2021);
            db.calificaciones.Add(CalifDismap);

            //db.configuraciones.Add(configuracion);

            db.SaveChanges();


        }
    }
}
