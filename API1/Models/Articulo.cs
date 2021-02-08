using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API1
{
    public class Articulo
    {
        private int codigo;
        private string nombre;
        private int precio;
        private int fabricante_id;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Fabricante_id { get => fabricante_id; set => fabricante_id = value; }
        public Fabricante fabricante { get; set; }

    }
}
