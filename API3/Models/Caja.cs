using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API3
{
    public class Caja
    {
        public string NumReferencia { get; set; }
        public string Contenido { get; set; }
        public int Valor { get; set; }
        public int CodigoAlmacen { get; set; }

        public Almacen almacen { get; set; }
    }
}
