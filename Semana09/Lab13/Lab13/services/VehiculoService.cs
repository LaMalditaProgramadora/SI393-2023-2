using Lab13.entities;
using Lab13.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.services
{
    internal class VehiculoService
    {
        private VehiculoRepository vRepository = new VehiculoRepository();
        public VehiculoService() { }

        public bool Registrar(Vehiculo vehiculo)
        {
            if (vRepository.Existe(vehiculo.Placa))
            {
                return false;
            }
            else
            {
                vRepository.Registrar(vehiculo);
                return true;
            }
        }

        public List<Vehiculo> ListarTodo()
        {
            return VehiculoRepository.ListarTodo();
        }

        public List<Vehiculo> ListarVehiculosMasOrdenesUltimos2Años()
        {
            return vRepository.ListarVehiculosMasOrdenesUltimos2Años();
        }

        public List<Vehiculo> OrdenarAscendentePorPlaca()
        {
            return vRepository.OrdenarAscendentePorPlaca();
        }

        public List<Vehiculo> ListarVehiculosMayorMontoPorServicio(String nombreServicio)
        {
            return vRepository.ListarVehiculosMayorMontoPorServicio(nombreServicio);
        }

        public List<Vehiculo> ListarVehiculosMenosOrdenes()
        {
            return vRepository.ListarVehiculosMenosOrdenes();
        }
    }
}
