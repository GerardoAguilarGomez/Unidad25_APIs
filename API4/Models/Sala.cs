using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API4
{
    public class Sala
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int CodigoPelicula { get; set; }

        public Pelicula pelicula { get; set; }
    }
}
