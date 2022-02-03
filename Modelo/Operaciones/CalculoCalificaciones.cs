using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Operaciones
{
    public class CalculoCalificaciones
    {
        public float peso1 { get; set; }
        public float peso2 { get; set; }
        public float peso3 { get; set; }
        public float peso4 { get; set; }
        public float peso5 { get; set; }
        public float peso6 { get; set; }
        public float peso7 { get; set; }
        public float notaMinima { get; set; }
        public CalculoCalificaciones(Configuracion configuracion)
        {
            this.peso1 = configuracion.PesoNota1;
            this.peso2 = configuracion.PesoNota2;
            this.peso3 = configuracion.PesoNota3;
            this.peso4 = configuracion.PesoNota4;
            this.peso5 = configuracion.PesoNota5;
            this.peso6 = configuracion.PesoNota6;
            this.peso7 = configuracion.PesoNota7;
            this.notaMinima = configuracion.NotaMinima;
        }
        public float NotaFinal(Calificacion calificacion) 
        {
            float respuesta;

            respuesta =
                peso1 * calificacion.Nota1 +
                peso2 * calificacion.Nota2 +
                peso3 * calificacion.Nota3 +
                peso4 * calificacion.Nota4 +
                peso5 * calificacion.Nota5 +
                peso6 * calificacion.Nota6 +
                peso7 * calificacion.Nota7; 

            respuesta =(float) Math.Round((double) respuesta,1);

            return respuesta;
        }

        public bool Aprobado(Calificacion calificacion)
        {
            return NotaFinal(calificacion) >= notaMinima;
        }
    }
}
