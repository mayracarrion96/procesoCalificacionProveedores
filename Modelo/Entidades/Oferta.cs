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
        public string Nombre { get; set; }
        public int ScoreBuro { get; set; }

        //Detalle de la postulacion
        public List<Postulacion> Postulacion { get; set; }
        public List<Oferta_Det> Oferta_Det { get; set; }

        //Propiedades de la relacion con proveedor
        public Periodo Periodo { get; set; }
        public int PeriodoId { get; set; }
    }
}
