using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API3
{
    public class Almacen
    {
        public int Codigo { get; set; }
        public string Lugar { get; set; }
        public int Capacidad { get; set; }

        public ICollection<Caja> Cajas { get; set; }
    }
}
