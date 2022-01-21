using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Oferta_Det
    {
        public int Oferta_DetId { get; set; }
        public decimal Precio { get; set; }
        public float LoteMinimo { get; set; }
        public float Descuento { get; set; }
        public Boolean Garantia { get; set; }
        public int TiempoEntrega { get; set; }

        
        //Propiedades de la relacion con oferta
        public Oferta Oferta { get; set; }
        public int OfertaId { get; set; }

        //Propiedades de la relacion con producto
        public Producto Producto { get; set; }
        public int ProductoId { get; set; }
    }
}
