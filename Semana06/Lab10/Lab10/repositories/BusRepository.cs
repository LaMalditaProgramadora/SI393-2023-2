using Lab10.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.repositories
{
    internal class BusRepository
    {
        private static List<Bus> buses = new();

        public BusRepository() { }

        public bool Existe(String matricula)
        {
            return buses.Exists(bus => bus.Matricula.Equals(matricula));
        }

        public void Registrar(Bus bus)
        {
            buses.Add(bus);
        }

        public static List<Bus> ListarTodo()
        {
            return buses;
        }

        public List<Bus> ListarBusesConRutasMasLargas() {
            List<Bus> busesTemp = new();
            Double maxKilometros = double.MinValue;
            foreach (Bus bus in buses)
            {
                Ruta? rutaMasLarga = bus.Rutas.MaxBy(ruta => ruta.Kilometros);
                if (rutaMasLarga != null) {
                    if (rutaMasLarga.Kilometros > maxKilometros)
                    {
                        maxKilometros = rutaMasLarga.Kilometros;
                        busesTemp.Clear();
                        busesTemp.Add(bus);
                    }
                    else if (rutaMasLarga.Kilometros == maxKilometros)
                    {
                        busesTemp.Add(bus);
                    }
                }
            }
            return busesTemp;
        }

        public List<Bus> ListarBusesConMenosRutas() {
            List<Bus> busesTemp = new();
            int menorCantidadRutas = int.MaxValue;
            foreach (Bus bus in buses) {
                int cantidadRutas = bus.Rutas.Count;
                if (cantidadRutas < menorCantidadRutas)
                {
                    menorCantidadRutas = cantidadRutas;
                    busesTemp.Clear();
                    busesTemp.Add(bus);
                }
                else if (cantidadRutas == menorCantidadRutas)
                {
                    busesTemp.Add(bus);
                }
            }
            return busesTemp;
        }
    }
}
