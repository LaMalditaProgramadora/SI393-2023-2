using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14.entidades
{
    internal class Trabajador
    {
        public Trabajador() { }
        public String Dni {  get; set; }
        public String Nombre {  get; set; }
        public String Puesto { get; set; }
        public double Sueldo { get; set; }
    }
}
