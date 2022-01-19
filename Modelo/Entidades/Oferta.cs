using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Oferta
    {
        public int OfertaId { get; set; }
        public decimal Precio { get; set; }
        public float LoteMinimo { get; set; }
        public float Descuento { get; set; }
        public Boolean Garantia { get; set; }
        public int TiempoEntrega { get; set; }
        public int ScoreBuro { get; set; }

        //Detalle de la postulacion
        //public List<Postulacion_Det> Postulacion_Detalle { get; set; }


        //Propiedades de la relacion con producto
        public Producto Producto { get; set; }
        public int ProductoId { get; set; }

        //Propiedades de la relacion con proveedor
        public Proveedor Proveedor { get; set; }
        public int ProveedorId { get; set; }
    }
}
