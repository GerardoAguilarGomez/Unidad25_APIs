using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API1
{
    public class ArticulosDto
    {
        //public int codigo;
        public string nombre;
        public int precio;
        public int fabricante_id;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Fabricante_id { get => fabricante_id; set => fabricante_id = value; }
    }
}
