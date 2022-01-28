using Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace CargaDatos
{
    public class DatosIniciales
    {
        public enum ListasTipo {
            Proveedores, Postulaciones, Calificaciones, Clasificaciones,
            Configuracion, Marcas, Ofertas, Ofertas_Det, Postulaciones_Det,
            Productos, Periodos
    
        };
        
        public Dictionary<ListasTipo, object> CargaDatos()
        {
            //-------------------------------------
            //LISTA DE PERIODOS
            //--------------------------------------
            #region
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

            #endregion
            
            //-------------------------------------
            //LISTA DE CONFIGURACION
            //--------------------------------------
            #region
            Configuracion configuracion = new Configuracion()
            {
                NotaMinima = 15.1f,
                PesoNota1 = 0.05f,
                PesoNota2 = 0.20f,
                PesoNota3 = 0.15f,
                PesoNota4 = 0.20f,
                PesoNota5 = 0.15f,
                PesoNota6 = 0.15f,
                PesoNota7 = 0.10f,
                PeriodoVigente=Periodo_2022
            };

            List<Configuracion> listaconfiguracion = new List<Configuracion>() {
                configuracion };
            #endregion

            //-------------------------------------
            //LISTA DE PROVEEDORES
            //--------------------------------------
            #region
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
            #endregion

            //-------------------------------------
            //LISTA DE MARCAS
            //--------------------------------------
            #region
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
            Marca Casio = new Marca()
            {
                Nombre = "Casio"
            };
            Marca Alex = new Marca()
            {
                Nombre = "Alex"
            };
            Marca Sharpie = new Marca()
            {
                Nombre = "Sharpie"
            };
            Marca HP = new Marca()
            {
                Nombre = "HP"
            };
            Marca Verbatim = new Marca()
            {
                Nombre = "Verbatim"
            };
            Marca Epson = new Marca()
            {
                Nombre = "Epson"
            };
            Marca Prakti = new Marca()
            {
                Nombre = "Prakti"
            };
            Marca Abro = new Marca()
            {
                Nombre = "Abro"
            };
            List<Marca> listamarcas = new List<Marca>() {
                Pelikan, Superior, BIC, Lancer, Jeff, Artesco, Genius, Xerox, Casio, Alex, Sharpie, HP, Verbatim,
                Epson, Prakti, Abro};
            #endregion

            //-------------------------------------
            //LISTA DE PRODUCTOS
            //--------------------------------------
            #region
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
            #endregion

            //-------------------------------------
            //LISTA DE CLASIFICACION
            //--------------------------------------
            #region
            Clasificacion Clasif1 = new Clasificacion()
            {
                Marca = Sharpie,
                Producto = Marcador
            };
            Clasificacion Clasif2 = new Clasificacion()
            {
                Marca = Xerox,
                Producto = Rollo
            };
            Clasificacion Clasif3 = new Clasificacion()
            {
                Marca = Genius,
                Producto = Auricular
            };
            Clasificacion Clasif4 = new Clasificacion()
            {
                Marca = BIC,
                Producto = BoligradoPF
            };
            Clasificacion Clasif5 = new Clasificacion()
            {
                Marca = BIC,
                Producto = BoligrafoPM
            };
            Clasificacion Clasif6 = new Clasificacion()
            {
                Marca = HP,
                Producto = Cartucho
            };
            Clasificacion Clasif7 = new Clasificacion()
            {
                Marca = Verbatim,
                Producto = CD
            };
            Clasificacion Clasif8 = new Clasificacion()
            {
                Marca = Epson,
                Producto = Tintas
            };
            Clasificacion Clasif9 = new Clasificacion()
            {
                Marca = Casio,
                Producto = Calculadora
            };
            Clasificacion Clasif10 = new Clasificacion()
            {
                Marca = Lancer,
                Producto = Papelera
            };
            Clasificacion Clasif11 = new Clasificacion()
            {
                Marca = Pelikan,
                Producto = MarcadorPerm
            };
            Clasificacion Clasif13 = new Clasificacion()
            {
                Marca = Genius,
                Producto = Camara
            };
            Clasificacion Clasif14 = new Clasificacion()
            {
                Marca = Xerox,
                Producto = Resma
            };
            Clasificacion Clasif15 = new Clasificacion()
            {
                Marca = Xerox,
                Producto = Papel
            };
            Clasificacion Clasif16 = new Clasificacion()
            {
                Marca = Prakti,
                Producto = Fundas
            };
            Clasificacion Clasif17 = new Clasificacion()
            {
                Marca = Abro,
                Producto = Cinta
            };
            Clasificacion Clasif18 = new Clasificacion()
            {
                Marca = Abro,
                Producto = Silicon
            };
            Clasificacion Clasif19 = new Clasificacion()
            {
                Marca = Superior,
                Producto = Archivador
            };
            Clasificacion Clasif20 = new Clasificacion()
            {
                Marca = Artesco,
                Producto = Etiqueta
            };
            Clasificacion Clasif21 = new Clasificacion()
            {
                Marca = Artesco,
                Producto = Libreta
            };
            Clasificacion Clasif22 = new Clasificacion()
            {
                Marca = Artesco,
                Producto = Hojas
            }; 
            Clasificacion Clasif23 = new Clasificacion()
            {
                Marca = Jeff,
                Producto = Estilete
            };
            Clasificacion Clasif24 = new Clasificacion()
            {
                Marca = Pelikan,
                Producto = Borrador
            };
            Clasificacion Clasif25 = new Clasificacion()
            {
                Marca = Alex,
                Producto = Clips
            };
            
            List<Clasificacion> listaclasificacion = new List<Clasificacion>() {
                Clasif1,          
                Clasif10, Clasif11, Clasif13, Clasif14, Clasif15, Clasif16,
                Clasif17, Clasif18, Clasif19, Clasif2, Clasif20, Clasif21, Clasif22, Clasif23,
                Clasif24, Clasif9, Clasif8, Clasif7, Clasif6, Clasif5, Clasif4, Clasif3, Clasif25
                };
            #endregion

            //-------------------------------------
            //LISTA DE OFERTAS
            //--------------------------------------
            #region
            Oferta OfertaDismap = new Oferta()
            {
                ScoreBuro = 887,
                Periodo = Periodo_2021,
            };
            Oferta OfertaOnerom = new Oferta()
            {
                ScoreBuro = 376,
                Periodo = Periodo_2021,
            };
            Oferta OfertaEcuampaques = new Oferta()
            {
                ScoreBuro = 447,
                Periodo = Periodo_2021,
            };
            Oferta OfertaVicents = new Oferta()
            {
                ScoreBuro = 960,
                Periodo = Periodo_2021,
            };
            Oferta OfertaSiglo = new Oferta()
            {
                ScoreBuro = 375,
                Periodo = Periodo_2021,
            };
            Oferta OfertaDilipa = new Oferta()
            {
                ScoreBuro = 124,
                Periodo = Periodo_2021,
            };
            Oferta OfertaOfi = new Oferta()
            {
                ScoreBuro = 629,
                Periodo = Periodo_2021,
            };
            Oferta OfertaEcolors = new Oferta()
            {
                ScoreBuro = 999,
                Periodo = Periodo_2021,
            };
            Oferta OfertaCompupaper = new Oferta()
            {
                ScoreBuro = 246,
                Periodo = Periodo_2021,
            };
            Oferta OfertaBudak = new Oferta()
            {
                ScoreBuro = 930,
                Periodo = Periodo_2021,
            };
            Oferta OfertaLeo = new Oferta()
            {
                ScoreBuro = 39,
                Periodo = Periodo_2021,
            };
            Oferta OfertaSantos = new Oferta()
            {
                ScoreBuro = 980,
                Periodo = Periodo_2021,
            };
            Oferta OfertaJYE = new Oferta()
            {
                ScoreBuro = 210,
                Periodo = Periodo_2021,
            };
            Oferta OfertaBalmer = new Oferta()
            {
                ScoreBuro = 910,
                Periodo = Periodo_2021,
            };
            Oferta OfertaSYS = new Oferta()
            {
                ScoreBuro = 911,
                Periodo = Periodo_2021,
            };
            List<Oferta> listaofertas = new List<Oferta>() {
                OfertaDismap, OfertaBalmer, OfertaBudak, OfertaCompupaper, OfertaDilipa,
                OfertaEcolors, OfertaEcuampaques, OfertaJYE, OfertaLeo, OfertaOfi, OfertaOnerom,
                OfertaSantos, OfertaSiglo, OfertaSYS, OfertaVicents};
            #endregion

            //-------------------------------------
            //LISTA DE OFERTAS_DET
            //--------------------------------------
            #region
            Oferta_Det OfertaDetDismap = new Oferta_Det()
            {
                Oferta = OfertaDismap,
                Producto = Tintas,
                Precio = (decimal)10.9f,
                LoteMinimo = 4125,
                Descuento = 10,
                Garantia = false,
                TiempoEntrega = 3
            };
            Oferta_Det OfertaDetBalmer = new Oferta_Det()
            {
                Oferta = OfertaDismap,
                Producto = Tintas,
                Precio = (decimal)14.9f,
                LoteMinimo = 60,
                Descuento = 0,
                Garantia = false,
                TiempoEntrega = 0
            };
            Oferta_Det OfertaDetBudak = new Oferta_Det()
            {
                Oferta = OfertaDismap,
                Producto = Tintas,
                Precio = (decimal)14.8f,
                LoteMinimo = 80,
                Descuento = 5,
                Garantia = false,
                TiempoEntrega = 0
            };
            Oferta_Det OfertaDetCompupaper = new Oferta_Det()
            {
                Oferta = OfertaDismap,
                Producto = Tintas,
                Precio = (decimal)12.00f,
                LoteMinimo = 75,
                Descuento = 10,
                Garantia = true,
                TiempoEntrega = 4
            };
            Oferta_Det OfertaDetDilipa = new Oferta_Det()
            {
                Oferta = OfertaDismap,
                Producto = Tintas,
                Precio = (decimal)13.8f,
                LoteMinimo = 175,
                Descuento = 6,
                Garantia = false,
                TiempoEntrega = 3
            };
            Oferta_Det OfertaDetEcolors = new Oferta_Det()
            {
                Oferta = OfertaDismap,
                Producto = Tintas,
                Precio = (decimal)9.1f,
                LoteMinimo = 250,
                Descuento = 10,
                Garantia = true,
                TiempoEntrega = 0
            };
            Oferta_Det OfertaDetJYE = new Oferta_Det()
            {
                Oferta = OfertaDismap,
                Producto = Tintas,
                Precio = (decimal)11.3f,
                LoteMinimo = 120,
                Descuento = 0,
                Garantia = false,
                TiempoEntrega = 5
            };
            Oferta_Det OfertaDetEcuaempaques = new Oferta_Det()
            {
                Oferta = OfertaDismap,
                Producto = Tintas,
                Precio = (decimal)10.1f,
                LoteMinimo = 110,
                Descuento = 0,
                Garantia = true,
                TiempoEntrega = 3
            };
            Oferta_Det OfertaDetLeo = new Oferta_Det()
            {
                Oferta = OfertaDismap,
                Producto = Tintas,
                Precio = (decimal)15.0f,
                LoteMinimo = 155,
                Descuento = 0,
                Garantia = false,
                TiempoEntrega = 6
            };
            Oferta_Det OfertaDetOfi = new Oferta_Det()
            {
                Oferta = OfertaDismap,
                Producto = Tintas,
                Precio = (decimal)13.2f,
                LoteMinimo = 150,
                Descuento = 4,
                Garantia = false,
                TiempoEntrega = 6
            };
            Oferta_Det OfertaDetOnerom = new Oferta_Det()
            {
                Oferta = OfertaDismap,
                Producto = Tintas,
                Precio = (decimal)13.3f,
                LoteMinimo = 70,
                Descuento = 0,
                Garantia = false,
                TiempoEntrega = 0
            };
            Oferta_Det OfertaDetSantos = new Oferta_Det()
            {
                Oferta = OfertaDismap,
                Producto = Tintas,
                Precio = (decimal)14.5f,
                LoteMinimo = 160,
                Descuento = 0,
                Garantia = false,
                TiempoEntrega = 1
            };
            Oferta_Det OfertaDetSiglo = new Oferta_Det()
            {
                Oferta = OfertaDismap,
                Producto = Tintas,
                Precio = (decimal)11.4f,
                LoteMinimo = 130,
                Descuento = 7,
                Garantia = false,
                TiempoEntrega = 0
            };
            Oferta_Det OfertaDetSYS = new Oferta_Det()
            {
                Oferta = OfertaDismap,
                Producto = Tintas,
                Precio = (decimal)11.4f,
                LoteMinimo = 85,
                Descuento = 0,
                Garantia = true,
                TiempoEntrega = 2
            };
            Oferta_Det OfertaDetVicents = new Oferta_Det()
            {
                Oferta = OfertaDismap,
                Producto = Tintas,
                Precio = (decimal)13.9f,
                LoteMinimo = 115,
                Descuento = 9,
                Garantia = false,
                TiempoEntrega = 1
            };
            List<Oferta_Det> listaofertasDet = new List<Oferta_Det>() {
                OfertaDetDismap, OfertaDetBalmer, OfertaDetBudak, OfertaDetCompupaper, OfertaDetDismap, OfertaDetEcuaempaques, OfertaDetJYE,  
                OfertaDetOfi, OfertaDetLeo, OfertaDetOnerom, OfertaDetSantos, OfertaDetSiglo, OfertaDetSYS, OfertaDetVicents, OfertaDetEcolors};
            #endregion

            //-------------------------------------
            //LISTA DE CALIFICACIONES
            //-------------------------------------
            #region
            Calificacion CalifDismap = new Calificacion()
            {
                Nota1 = 0.1f,
                Nota2 = 4.3f,
                Nota3 = 3.8f,
                Nota4 = 5.0f,
                Nota5 = 0.1f,
                Nota6 = 2.0f,
                Nota7 = 4.0f,
            };
            Calificacion CalifBudak = new Calificacion()
            {
                Nota1 = 0.1f,
                Nota2 = 2.7f,
                Nota3 = 2.9f,
                Nota4 = 5.0f,
                Nota5 = 0.1f,
                Nota6 = 5.0f,
                Nota7 = 4.6f,
            };
            Calificacion CalifCompupaper = new Calificacion()
            {
                Nota1 = 5.0f,
                Nota2 = 3.6f,
                Nota3 = 2.7f,
                Nota4 = 5.0f,
                Nota5 = 5.0f,
                Nota6 = 1.0f,
                Nota7 = 2.2f,
            };
            Calificacion CalifDilipa = new Calificacion()
            {
                Nota1 = 5.0f,
                Nota2 = 3.1f,
                Nota3 = 4.9f,
                Nota4 = 5.0f,
                Nota5 = 0.1f,
                Nota6 = 2.0f,
                Nota7 = 1.5f,
            };
            Calificacion CalifBalmer = new Calificacion()
            {
                Nota1 = 5.0f,
                Nota2 = 2.5f,
                Nota3 = 2.5f,
                Nota4 = 0.1f,
                Nota5 = 0.1f,
                Nota6 = 5.0f,
                Nota7 = 4.4f,
            };
            Calificacion CalifEcuaempaques = new Calificacion()
            {
                Nota1 = 5.0f,
                Nota2 = 4.9f,
                Nota3 = 3.4f,
                Nota4 = 0.1f,
                Nota5 = 5.0f,
                Nota6 = 2.0f,
                Nota7 = 3.2f,
            };
            Calificacion CalifJYE = new Calificacion()
            {
                Nota1 = 0.1f,
                Nota2 = 3.9f,
                Nota3 = 3.6f,
                Nota4 = 0.1f,
                Nota5 = 0.1f,
                Nota6 = 1.0f,
                Nota7 = 2.0f,
            };
            Calificacion CalifOfi = new Calificacion()
            {
                Nota1 = 5.0f,
                Nota2 = 3.5f,
                Nota3 = 3.9f,
                Nota4 = 5.0f,
                Nota5 = 0.1f,
                Nota6 = 1.0f,
                Nota7 = 3.5f,
            };
            Calificacion CalifLeo = new Calificacion()
            {
                Nota1 = 0.1f,
                Nota2 = 4.7f,
                Nota3 = 4.3f,
                Nota4 = 0.1f,
                Nota5 = 0.1f,
                Nota6 = 1.0f,
                Nota7 = 1.0f,
            };
            Calificacion CalifOnerom = new Calificacion()
            {
                Nota1 = 0.1f,
                Nota2 = 3.2f,
                Nota3 = 2.6f,
                Nota4 = 0.1f,
                Nota5 = 0.1f,
                Nota6 = 5.0f,
                Nota7 = 3.0f,
            };
            Calificacion CalifSantos = new Calificacion()
            {
                Nota1 = 0.1f,
                Nota2 = 2.6f,
                Nota3 = 4.7f,
                Nota4 = 0.1f,
                Nota5 = 0.1f,
                Nota6 = 4.0f,
                Nota7 = 4.8f,
            };
            Calificacion CalifSiglo = new Calificacion()
            {
                Nota1 = 5.0f,
                Nota2 = 3.8f,
                Nota3 = 2.8f,
                Nota4 = 5.0f,
                Nota5 = 0.1f,
                Nota6 = 5.0f,
                Nota7 = 2.9f,
            };
            Calificacion CalifSYS = new Calificacion()
            {
                Nota1 = 5.0f,
                Nota2 = 3.8f,
                Nota3 = 3.1f,
                Nota4 = 0.1f,
                Nota5 = 5.0f,
                Nota6 = 3.0f,
                Nota7 = 4.5f,
            };
            Calificacion CalifVicents = new Calificacion()
            {
                Nota1 = 5.0f,
                Nota2 = 2.9f,
                Nota3 = 3.5f,
                Nota4 = 5.0f,
                Nota5 = 0.1f,
                Nota6 = 4.0f,
                Nota7 = 4.7f,
            };
            Calificacion CalifEcolors = new Calificacion()
            {
                Nota1 = 5.0f,
                Nota2 = 5.0f,
                Nota3 = 5.0f,
                Nota4 = 5.0f,
                Nota5 = 5.0f,
                Nota6 = 5.0f,
                Nota7 = 0.0f,
            };
            List<Calificacion> listacalificaciones = new List<Calificacion>() {
                CalifDismap, CalifDilipa, CalifCompupaper, CalifBudak,
                CalifBalmer, CalifEcuaempaques, CalifJYE,
                CalifOfi, CalifLeo, CalifOnerom, CalifSantos, CalifSiglo, CalifSYS, CalifVicents, CalifEcolors};
            #endregion

            //-------------------------------------
            //LISTA DE POSTULACION
            //--------------------------------------
            #region
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
            #endregion

            //-------------------------------------
            //LISTA DE POSTULACION_DET
            //--------------------------------------
            #region
            Postulacion_Det PostDetDismap_2021 = new Postulacion_Det()
            {
                Postulacion = PostDismap_2021,
                Calificacion = CalifDismap
            };
            Postulacion_Det PostDetDilipa_2021 = new Postulacion_Det()
            {
                Postulacion = PostDilipa_2021,
                Calificacion = CalifDilipa
            };
            Postulacion_Det PostDetCompupaper_2021 = new Postulacion_Det()
            {
                Postulacion = PostCompupaper_2021,
                Calificacion = CalifCompupaper
            };
            Postulacion_Det PostDetBudak_2021 = new Postulacion_Det()
            {
                Postulacion = PostBudak_2021,
                Calificacion = CalifBudak
            };
            Postulacion_Det PostDetBalmer_2021 = new Postulacion_Det()
            {
                Postulacion = PostBalmer_2021,
                Calificacion = CalifBalmer
            };
            Postulacion_Det PostDetEcuaempaques_2021 = new Postulacion_Det()
            {
                Postulacion = PostEcuampaques_2021,
                Calificacion = CalifEcuaempaques
            };
            Postulacion_Det PostDetJYE_2021 = new Postulacion_Det()
            {
                Postulacion = PostJYE_2021,
                Calificacion = CalifJYE
            };
            Postulacion_Det PostDetOfi_2021 = new Postulacion_Det()
            {
                Postulacion = PostOfi_2021,
                Calificacion = CalifOfi
            };
            Postulacion_Det PostDetLeo_2021 = new Postulacion_Det()
            {
                Postulacion = PostLeo_2021,
                Calificacion = CalifLeo
            };
            Postulacion_Det PostDetOnerom_2021 = new Postulacion_Det()
            {
                Postulacion = PostOnerom_2021,
                Calificacion = CalifOnerom
            };
            Postulacion_Det PostDetSantos_2021 = new Postulacion_Det()
            {
                Postulacion = PostSantos_2021,
                Calificacion = CalifSantos
            };
            Postulacion_Det PostDetSiglo_2021 = new Postulacion_Det()
            {
                Postulacion = PostSiglo_2021,
                Calificacion = CalifSiglo
            };
            Postulacion_Det PostDetSYS_2021 = new Postulacion_Det()
            {
                Postulacion = PostSYS_2021,
                Calificacion = CalifSYS
            };
            Postulacion_Det PostDetVicents_2021 = new Postulacion_Det()
            {
                Postulacion = PostVicents_2021,
                Calificacion = CalifVicents
            };
            Postulacion_Det PostDetEcolors_2021 = new Postulacion_Det()
            {
                Postulacion = PostEcolors_2021,
                Calificacion = CalifEcolors
            };
            List<Postulacion_Det> listapostulacionDet = new List<Postulacion_Det>() {
                PostDetDismap_2021, PostDetDilipa_2021, PostDetCompupaper_2021, PostDetBudak_2021,
                PostDetBalmer_2021, PostDetEcuaempaques_2021, PostDetJYE_2021,
                PostDetOfi_2021, PostDetLeo_2021, PostDetOnerom_2021, PostDetSantos_2021, PostDetSiglo_2021,
                PostDetSYS_2021, PostDetVicents_2021, PostDetEcolors_2021 };
            #endregion

            //-------------------------------------
            //DICCIONARIO CONTIENE TODAS LAS LISTAS
            //--------------------------------------
            Dictionary<ListasTipo, object> dicListasDatos = new Dictionary<ListasTipo, object>()
            {
                {ListasTipo.Periodos, listaperiodos },
                {ListasTipo.Configuracion, listaconfiguracion },
                {ListasTipo.Proveedores, listaproveedores },
                {ListasTipo.Marcas, listamarcas },
                {ListasTipo.Productos, listaproductos },
                {ListasTipo.Clasificaciones, listaclasificacion },
                {ListasTipo.Ofertas, listaofertas },
                {ListasTipo.Ofertas_Det, listaofertasDet },
                {ListasTipo.Calificaciones, listacalificaciones },
                {ListasTipo.Postulaciones, listapostulaciones },
                {ListasTipo.Postulaciones_Det, listapostulacionDet },


            };
            return dicListasDatos;
        }
    }
}
