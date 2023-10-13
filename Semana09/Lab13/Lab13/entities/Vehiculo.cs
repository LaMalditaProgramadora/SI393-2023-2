using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.entities
{
    internal class Vehiculo
    {
        public Vehiculo() { }
        public String Placa { get; set; }
        public String NumeroTarjetaPropiedad { get; set; }
        public String Modelo { get; set; }
        public String Color { get; set; }
        public String NumeroMotor { get; set; }
        public String FechaUltimoIngreso { get; set; }
        public List<Orden> Ordenes { get; set; }
    }
}
