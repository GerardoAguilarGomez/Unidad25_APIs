﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2
{
    public class Departamento
    {
        public Departamento()
        {
            Empleados = new HashSet<Empleado>();
        }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Presupuesto { get; set; }

        public ICollection<Empleado> Empleados { get; set; }
    }
}
