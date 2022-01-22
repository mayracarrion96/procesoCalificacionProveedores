using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Configuracion
    {
        public int ConfiguracionId { get; set; }
        public float NotaMinima { get; set; }
        public float PesoNota1 { get; set; }
        public float PesoNota2 { get; set; }
        public float PesoNota3 { get; set; }
        public float PesoNota4 { get; set; }
        public float PesoNota5 { get; set; }
        public float PesoNota6 { get; set; }
        public float PesoNota7 { get; set; }
        
        //Propiedades de la relacion con periodos
        public Periodo PeriodoVigente { get; set; }
        public int PeriodoVigenteId { get; set; }
    }
}
