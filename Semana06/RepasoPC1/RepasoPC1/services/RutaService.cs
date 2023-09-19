using RepasoPC1.entities;
using RepasoPC1.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoPC1.services
{
    internal class RutaService
    {
        private RutaRepository rutaRepository = new();
        public RutaService() { }

        public bool Registrar(String matricula, Ruta ruta)
        {
            if (rutaRepository.Existe(ruta.Codigo))
            {
                return false;
            }
            else
            {
                rutaRepository.Registrar(matricula, ruta);
                return true;
            }
        }

        public List<Ruta> ListarTodo(String matricula)
        {
            return rutaRepository.ListarTodo(matricula);
        }

        public List<Ruta> ListarRutasPorConductorBus(String conductor)
        {
            return rutaRepository.ListarRutasPorConductorBus(conductor);
        }
    }
}
