﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjEmpresa
{
    internal class Empleado
    {
        public Empleado() { }

        public String Nombre { get; set; }
        public String Categoria { get; set; }
        public int MinutosTardanza { get; set; }
        public int LlamadasAtencion { get; set; }
        public double Pago { get; set; }
    }
}
