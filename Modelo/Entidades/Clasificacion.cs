using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Clasificacion
    {
        //Propiedades de la relacion con marca
        public Marca Marca { get; set; }
        public int MarcaId { get; set; }

        //Propiedades de la relacion con marca
        public Producto Producto { get; set; }
        public int ProductoId { get; set; }
    }
}
