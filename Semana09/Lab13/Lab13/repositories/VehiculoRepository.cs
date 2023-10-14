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
            List<Vehiculo> vehiculosTemp = new List<Vehiculo>();
            int maxOrdenes = int.MinValue;

            foreach (Vehiculo vehiculo in vehiculos)
            {
                // Filtrar por año
                List<Orden> ordenesTemp = vehiculo.Ordenes.FindAll(o => ConvertirFecha(o.FechaServicio).AddYears(2) >= DateTime.Now);
                // Obtenemos la cantidad de órdenes.
                int cantidadOrdenes = ordenesTemp.Count;
                // Obtener los que tienen más ordenes
                if (cantidadOrdenes > maxOrdenes)
                {
                    maxOrdenes = cantidadOrdenes;
                    vehiculosTemp.Clear();
                    vehiculosTemp.Add(vehiculo);
                }
                else if (cantidadOrdenes > maxOrdenes)
                {
                    vehiculosTemp.Add(vehiculo);
                }
            }
            return vehiculosTemp;
        }

        public List<Vehiculo> OrdenarAscendentePorPlaca()
        {
            List<Vehiculo> vehiculosTemp = vehiculos.OrderBy(v => v.Placa).ToList();
            return vehiculosTemp;
        }

        public List<Vehiculo> ListarVehiculosMayorMontoPorServicio(String nombreServicio)
        {
            List<Vehiculo> vehiculosTemp = new List<Vehiculo>();
            double maxMonto = double.MinValue;

            foreach (Vehiculo vehiculo in vehiculos)
            {
                // Filtrar por nombre servicio
                List<Orden> ordenesTemp = vehiculo.Ordenes.FindAll(o => o.NombreServicio.Equals(nombreServicio));

                if (ordenesTemp.Count > 0) {
                    // Calcular mayor monto
                    double monto = ordenesTemp.Max(o => o.Monto);
                    if (monto > maxMonto)
                    {
                        maxMonto = monto;
                        vehiculosTemp.Clear();
                        vehiculosTemp.Add(vehiculo);
                    }
                    else if (monto > maxMonto)
                    {
                        vehiculosTemp.Add(vehiculo);
                    }
                }
            }
            return vehiculosTemp;
        }

        public List<Vehiculo> ListarVehiculosMenosOrdenes()
        {
            List<Vehiculo> vehiculosTemp = new List<Vehiculo>();
            int minOrdenes = int.MaxValue;

            foreach (Vehiculo vehiculo in vehiculos)
            {
                // Obtenemos la cantidad de órdenes.
                int cantidadOrdenes = vehiculo.Ordenes.Count;
                // Obtener los que tienen menos ordenes
                if (cantidadOrdenes < minOrdenes)
                {
                    minOrdenes = cantidadOrdenes;
                    vehiculosTemp.Clear();
                    vehiculosTemp.Add(vehiculo);
                }
                else if (cantidadOrdenes > minOrdenes)
                {
                    vehiculosTemp.Add(vehiculo);
                }
            }
            return vehiculosTemp;
        }

        private DateTime ConvertirFecha(String fecha)
        {
            return DateTime.ParseExact(fecha, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
