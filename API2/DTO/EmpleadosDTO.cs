using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2
{
    public class EmpleadosDTO
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int CodigoDepartamento { get; set; }
    }
}
