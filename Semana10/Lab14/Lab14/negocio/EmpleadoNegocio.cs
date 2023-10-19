using Lab14.datos;
using Lab14.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14.negocio
{
    // Capa de Negocio
    internal class EmpleadoNegocio
    {
        private EmpleadoDatos eDatos = new EmpleadoDatos();
        public EmpleadoNegocio() { }

        public bool Registrar(Empleado empleado)
        {
            if (eDatos.Existe(empleado.Dni))
            {
                return false;
            }
            else
            {
                // Lógica del negocio
                switch (empleado.Puesto)
                {
                    case "Auxiliar": empleado.Sueldo = 2000; break;
                    case "Asistente": empleado.Sueldo = 3000; break;
                    case "Administrador": empleado.Sueldo = 5000; break;
                    default: empleado.Sueldo = 2000; break;
                }
                eDatos.Registrar(empleado);
                return true;
            }
        }

        public void Eliminar(String dni)
        {
            eDatos.Eliminar(dni);
        }

        public List<Empleado> ListarTodo()
        {
            return EmpleadoDatos.ListarTodo();
        }

        public List<Empleado> ListarOrdenadoPorSueldo()
        {
            return eDatos.ListarOrdenadoPorSueldo();
        }
    }
}
