using RepasoPC1.entities;
using System.Collections.Generic;

namespace RepasoPC1.repositories
{
    internal class RutaRepository
    {
        public RutaRepository() { }

        public bool Existe(String codigoRuta)
        {
            List<Bus> buses = BusRepository.ListarTodo();
            foreach (Bus bus in buses)
            {
                bool existe = bus.Rutas.Exists(b => b.Equals(codigoRuta));
                if (existe)
                {
                    return true;
                }
            }
            return false;
        }

        public void Registrar(String matricula, Ruta ruta)
        {
            List<Bus> buses = BusRepository.ListarTodo();
            Bus? bus = buses.Find(b => b.Matricula.Equals(matricula));
            if (bus != null) {
                bus.Rutas.Add(ruta);
            }
        }

        public List<Ruta> ListarTodo(String matricula)
        {
            List<Bus> buses = BusRepository.ListarTodo();
            Bus? bus = buses.Find(b => b.Matricula.Equals(matricula));
            if (bus != null)
            {
                return bus.Rutas;
            }
            else return new List<Ruta>();
        }

        public List<Ruta> ListarRutasPorConductorBus(String conductor)
        {
            List<Ruta> rutasTemp = new();
            List<Bus> buses = BusRepository.ListarTodo();
            List <Bus> busesTemp = buses.FindAll(b => b.Conductor.Equals(conductor));
            foreach(Bus bus in busesTemp)
            {
                rutasTemp.AddRange(bus.Rutas);
            }
            return rutasTemp;
        }
    }
}
