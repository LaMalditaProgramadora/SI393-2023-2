using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoPC1.entities
{
    internal class Ruta
    {
        public Ruta(string codigo, string origen, string destino, double kilometros)
        {
            Codigo = codigo;
            Origen = origen;
            Destino = destino;
            Kilometros = kilometros;
        }

        public String Codigo { get; set; }
        public String Origen { get; set; }
        public String Destino { get; set; }
        public Double Kilometros { get; set; }

    }
}
