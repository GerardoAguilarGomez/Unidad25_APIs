using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API4
{
    public class Pelicula
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int CalificacionEdad { get; set; }
        public ICollection<Sala> Salas { get; set; }
    }
}
