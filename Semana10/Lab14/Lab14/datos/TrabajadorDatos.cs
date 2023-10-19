using Lab14.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14.datos
{
    // Capa de Datos
    internal class TrabajadorDatos
    {
        public TrabajadorDatos() { }

        // Simulamos el acceso a base de datos
        private static List<Trabajador> trabajadores = new List<Trabajador>();

        public bool Existe(String dni) {
            return trabajadores.Exists(t => t.Dni.Equals(dni));
        }

        public void Registrar(Trabajador trabajador) {
            trabajadores.Add(trabajador);
        }

        public void Eliminar(String dni) {
            trabajadores.RemoveAll(t => t.Dni.Equals(dni));
        }

        public static List<Trabajador> ListarTodo() {
            return trabajadores;
        }

        public List<Trabajador> ListarOrdenadoPorSueldo()
        {
            return trabajadores.OrderBy(t => t.Sueldo).ToList();
        }
    }
}
