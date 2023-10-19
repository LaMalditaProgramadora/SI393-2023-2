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
    internal class TrabajadorNegocio
    {
        private TrabajadorDatos tDatos = new TrabajadorDatos();
        public TrabajadorNegocio() { }

        public bool Registrar(Trabajador trabajador)
        {
            if (tDatos.Existe(trabajador.Dni))
            {
                return false;
            }
            else {
                // Regla de Negocio
                switch (trabajador.Puesto)
                {
                    case "Auxiliar": trabajador.Sueldo = 2000; break;
                    case "Asistente": trabajador.Sueldo = 3000; break;
                    case "Administrador": trabajador.Sueldo = 5000; break;
                    default: trabajador.Sueldo = 2000; break;
                }
                tDatos.Registrar(trabajador);
                return true;
            }
        }

        public void Eliminar(String dni)
        {
            tDatos.Eliminar(dni);
        }

        public List<Trabajador> ListarTodo()
        {
            return TrabajadorDatos.ListarTodo();
        }

        public List<Trabajador> ListarOrdenadoPorSueldo()
        {
            return tDatos.ListarOrdenadoPorSueldo();
        }
    }
}
