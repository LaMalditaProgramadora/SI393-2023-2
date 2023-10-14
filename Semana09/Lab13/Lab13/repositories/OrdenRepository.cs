using Lab13.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.repositories
{
    internal class OrdenRepository
    {
        public OrdenRepository() { }

        public bool Existe(String codigo)
        {
            List<Vehiculo> vehiculos = VehiculoRepository.ListarTodo();
            foreach (Vehiculo vehiculo in vehiculos)
            {
                bool existe = vehiculo.Ordenes.Exists(o => o.Codigo.Equals(codigo));
                if (existe)
                {
                    return true;
                }
            }
            return false;
        }

        public void Registrar(String placa, Orden orden)
        {
            List<Vehiculo> vehiculos = VehiculoRepository.ListarTodo();

            // Buscar el vehículo por placa
            Vehiculo vehiculo = vehiculos.Find(v => v.Placa.Equals(placa));

            if (vehiculo != null)
            {
                vehiculo.Ordenes.Add(orden);
            }
            
        }

        public List<Orden> ListarTodo(String placa)
        {
            List<Vehiculo> vehiculos = VehiculoRepository.ListarTodo();

            // Buscar el vehículo por placa
            Vehiculo vehiculo = vehiculos.Find(v => v.Placa.Equals(placa));

            if (vehiculo != null)
            {
                return vehiculo.Ordenes;
            }
            else
            {
                return new List<Orden>();
            }
        }
    }
}
