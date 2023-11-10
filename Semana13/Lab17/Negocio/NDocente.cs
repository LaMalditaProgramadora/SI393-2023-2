using Datos;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class NDocente
    {
        private DDocente dDocente = new DDocente();
        public NDocente() { }

        public String Registrar(Docente docente)
        {
            return dDocente.Registrar(docente);
        }

        public String Modificar(Docente docente)
        {
            return dDocente.Modificar(docente);
        }

        public String Elimnar(int id)
        {
            return dDocente.Elimnar(id);
        }

        public List<Docente> ListarTodo()
        {
            return dDocente.ListarTodo();
        }

        public List<Docente> ListarTodoPorEscuela(String escuela)
        {
            return dDocente.ListarTodoPorEscuela(escuela);
        }
    }
}
