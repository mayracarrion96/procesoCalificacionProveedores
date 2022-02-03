using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public enum PeriodoEstado { Abierto, Cerrado }
    public class Periodo
    {
        
        public int PeriodoId { get; set; }
        public string Nombre { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }

        public PeriodoEstado Estado { get; set; }

        //Detalle de la oferta y postulacion
        public List<Oferta> Oferta { get; set; }
        public List<Postulacion> Postulacion { get; set; }
    }
}
