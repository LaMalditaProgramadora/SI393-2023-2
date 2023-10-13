using Lab13.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.repositories
{
    internal class VehiculoRepository
    {
        private static List<Vehiculo> vehiculos = new List<Vehiculo>();

        public VehiculoRepository() { }

        public bool Existe(String placa)
        {
            return vehiculos.Exists(v => v.Placa.Equals(placa));
        }

        public void Registrar(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }

        public static List<Vehiculo> ListarTodo()
        {
            return vehiculos;
        }

        public List<Vehiculo> ListarVehiculosMasOrdenesUltimos2Años()
        {
            List<Vehiculo> vehiculosTmp = new List<Vehiculo>();
            int maxOrdenes = int.MinValue;
            foreach (Vehiculo vehiculo in vehiculos)
            {
                // Filtramos por año
                List<Orden> ordenesTemp = vehiculo.Ordenes.FindAll(o => ConvertirFecha(o.FechaServicio).AddYears(2) > DateTime.Now);
                // Obtenermos la cantidad de órdenes
                int cantidadOrdenes = ordenesTemp.Count;
                // Obtenemos los que tienen más órdenes
                if (cantidadOrdenes > maxOrdenes)
                {
                    maxOrdenes = cantidadOrdenes;
                    vehiculosTmp.Clear();
                    vehiculosTmp.Add(vehiculo);
                }
                else if (cantidadOrdenes == maxOrdenes)
                {
                    vehiculosTmp.Add(vehiculo);
                }
            }
            return vehiculosTmp;
        }

        public List<Vehiculo> OrdenarAscendentePorPlaca()
        {
            // OrderBy ordena de forma ascendente
            List<Vehiculo> vehiculosTmp = vehiculos.OrderBy(v => v.Placa).ToList();
            return vehiculosTmp;
        }

        public List<Vehiculo> ListarVehiculosMayorMontoPorServicio(String nombreServicio)
        {
            List<Vehiculo> vehiculosTmp = new List<Vehiculo>();

            double maxMonto = double.MinValue;
            foreach (Vehiculo vehiculo in vehiculos)
            {
                // Filtramos por nombre del servicio
                List<Orden> ordenes = vehiculo.Ordenes.FindAll(o => o.NombreServicio.Equals(nombreServicio));

                if (ordenes.Count > 0)
                {
                    // Obtenermos el mayor monto
                    double monto = ordenes.Max(o => o.Monto);
                    // Obtenemos los que tienen el mayor monto
                    if (monto > maxMonto)
                    {
                        maxMonto = monto;
                        vehiculosTmp.Clear();
                        vehiculosTmp.Add(vehiculo);
                    }
                    else if (monto == maxMonto)
                    {
                        vehiculosTmp.Add(vehiculo);
                    }
                }
            }
            return vehiculosTmp;
        }

        public List<Vehiculo> ListarVehiculosMenosOrdenes()
        {
            List<Vehiculo> vehiculosTmp = new List<Vehiculo>();
            int minOrdenes = int.MaxValue;
            foreach (Vehiculo vehiculo in vehiculos)
            {
                // Obtenermos la cantidad de órdenes
                int cantidadOrdenes = vehiculo.Ordenes.Count;
                // Obtenemos los que tienen menos órdenes
                if (cantidadOrdenes < minOrdenes)
                {
                    minOrdenes = cantidadOrdenes;
                    vehiculosTmp.Clear();
                    vehiculosTmp.Add(vehiculo);
                }
                else if (cantidadOrdenes == minOrdenes)
                {
                    vehiculosTmp.Add(vehiculo);
                }
            }
            return vehiculosTmp;
        }

        private DateTime ConvertirFecha(String fecha) {
            return DateTime.ParseExact(fecha, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
        }
      
    }
}
