using Datos;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class NCurso
    {
        private DCurso dCurso = new DCurso();
        public NCurso() { }

        public String Registrar(Curso curso)
        {
            return dCurso.Registrar(curso);
        }

        public String Modificar(Curso curso)
        {
            return dCurso.Modificar(curso);
        }

        public String Elimnar(int id)
        {
            return dCurso.Elimnar(id);
        }

        public List<Curso> ListarTodo()
        {
            return dCurso.ListarTodo();
        }
    }
}
