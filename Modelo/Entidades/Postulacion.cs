using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public enum PostulacionEstado { Aprobada, Rechazada, Pendiente, Anulado }
    public class Postulacion
    {
        public int PostulacionId { get; set; }
        public string Nombre { get; set; }
        public PostulacionEstado Estado { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        //Detalle de la postulacion
        public List<Postulacion_Det> Postulacion_Detalle { get; set; }

        //Propiedades de la relacion con proveedor
        public Proveedor Proveedor { get; set; }
        public int ProveedorId { get; set; }

        //Propiedades de la relacion con oferta
        public Oferta Oferta { get; set; }
        public int? OfertaId { get; set; }

        //Propiedades de la relacion con periodo
        public Periodo Periodo { get; set; }
        public int PeriodoId { get; set; }
    }
}
