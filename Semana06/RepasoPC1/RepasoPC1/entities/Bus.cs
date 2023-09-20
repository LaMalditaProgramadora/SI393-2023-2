using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoPC1.entities
{
    internal class Bus
    {
        public Bus(string matricula, string tipo, string conductor)
        {
            Matricula = matricula;
            Tipo = tipo;
            Conductor = conductor;
            Rutas = new();
        }

        public String Matricula {  get; set; }
        public String Tipo { get; set; }
        public String Conductor { get; set; }

        public List<Ruta> Rutas { get; set; }

    }
}
