using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Periodo
    {
        public int PeriodoId { get; set; }
        public string Estado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        //Detalle de la oferta y postulacion
        public List<Oferta> Oferta { get; set; }
        public List<Postulacion> Postulacion { get; set; }
    }
}
