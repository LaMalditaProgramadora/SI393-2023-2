using Lab14.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14.datos
{
    // Capa de Datos
    internal class EmpleadoDatos
    {
        private static List<Empleado> empleados = new List<Empleado>();
        public EmpleadoDatos() { }

        public bool Existe(String dni)
        {
            return empleados.Exists(e => e.Dni.Equals(dni));
        }

        public void Registrar(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public void Eliminar(String dni)
        {
            empleados.RemoveAll(e => e.Dni.Equals(dni));
        }

        public static List<Empleado> ListarTodo()
        {
            return empleados;
        }

        public List<Empleado> ListarOrdenadoPorSueldo()
        {
            return empleados.OrderBy(e => e.Sueldo).ToList();
        }
    }
}
