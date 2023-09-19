using RepasoPC1.entities;

namespace RepasoPC1.repositories
{
    internal class BusRepository
    {
        private static List<Bus> buses = new();

        public BusRepository() { }

        public bool Existe(String matricula) {
            return buses.Exists(b => b.Matricula.Equals(matricula));
        }

        public void Registrar(Bus bus)
        {
            buses.Add(bus);
        }

        public static List<Bus> ListarTodo() {
            return buses;
        }

        public List<Bus> ListarBusesConRutasMasLargas()
        {
            List<Bus> busesTemp = new();
            Double maxKilometros = 0;
            foreach (Bus bus in buses)
            {
                Ruta? rutaMasLarga = bus.Rutas.MaxBy(r => r.Kilometros);
                if (rutaMasLarga != null) {
                    if (rutaMasLarga.Kilometros > maxKilometros) {
                        maxKilometros = rutaMasLarga.Kilometros;
                        busesTemp.Clear();
                        busesTemp.Add(bus);
                    } else if (rutaMasLarga.Kilometros == maxKilometros) {
                        busesTemp.Add(bus);
                    }
                }
            }
            return busesTemp;
        }

        public List<Bus> ListarBusesConMenosRutas()
        {
            List<Bus> busesTemp = new();
            int minCantidadBuses = int.MaxValue;
            foreach (Bus bus in buses)
            {
                int cantidadBuses = bus.Rutas.Count;
                if (cantidadBuses < minCantidadBuses)
                {
                    minCantidadBuses = cantidadBuses;
                    busesTemp.Clear();
                    busesTemp.Add(bus);
                }
                else if (cantidadBuses == minCantidadBuses)
                {
                     busesTemp.Add(bus);
                }
            }
            return busesTemp;
        }
    }
}
