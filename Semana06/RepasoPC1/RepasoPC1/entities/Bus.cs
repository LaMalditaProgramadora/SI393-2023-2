using System;
using System.Collections.Generic;
namespace RepasoPC1.entities
{
    internal class Bus
    {
        public Bus(String matricula, String tipo, String conductor) {
            Matricula = matricula;
            Tipo = tipo;
            Conductor = conductor;
            Rutas = new();
        }

        public String Matricula { get; set; }
        public String Tipo { get; set;}
        public String Conductor { get; set; }

        public List<Ruta> Rutas { get; set; }

        public String[] ConvertirArregloString() {
            String[] row = { Matricula, Tipo, Conductor };
            return row;
        }
    }
}
