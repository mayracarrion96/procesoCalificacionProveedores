using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Calificacion
    {
        public int CalificacionId { get; set; }
        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float Nota3 { get; set; }
        public float Nota4 { get; set; }
        public float Nota5 { get; set; }
        public float Nota6 { get; set; }
        public float Nota7 { get; set; }

        //Propiedades de la relacion con postulacion_detalles
        public Postulacion_Det Postulacion_Det { get; set; }
        public int Postulacion_DetId { get; set; }
    }
}
