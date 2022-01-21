using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Marca
    {
        public int MarcaId { get; set; }
        public string Nombre { get; set; }
        //Detalle de la clasificacion
        public List<Clasificacion> Clasificacion { get; set; }
    }
}
