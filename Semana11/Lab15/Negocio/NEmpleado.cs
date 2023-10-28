using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEmpleado
    {
        private DEmpleado dEmpleado = new DEmpleado();
        public NEmpleado() { }

        public String Registrar(EEmpleado empleado)
        {
                // Lógica del negocio
                switch (empleado.Puesto)
                {
                    case "Auxiliar": empleado.Sueldo = 2000; break;
                    case "Asistente": empleado.Sueldo = 3000; break;
                    case "Administrador": empleado.Sueldo = 5000; break;
                    default: empleado.Sueldo = 2000; break;
                }
                return dEmpleado.Registrar(empleado);
            
        }

        public String Eliminar(int id)
        {
            return dEmpleado.Eliminar(id);
        }

        public List<EEmpleado> ListarTodo()
        {
            return dEmpleado.ListarTodo();
        }

        public List<EEmpleado> ListarOrdenadoPorSueldo()
        {
            return dEmpleado.ListarOrdenadoPorSueldo();
        }
    }
}
