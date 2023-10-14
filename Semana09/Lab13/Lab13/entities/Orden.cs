using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.entities
{
    internal class Orden
    {
        public Orden() { }
        public String Codigo { get; set; }
        public String NombreServicio { get; set; }
        public String NombreCliente { get; set; }
        public double Monto { get; set; }
        public String FechaServicio { get; set; }
    }
}
