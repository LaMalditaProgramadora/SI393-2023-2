using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCurso
    {
        private DCurso dCurso = new DCurso();

        public String Registrar(Curso curso)
        {
            return dCurso.Registrar(curso);
        }

        public String Modificar(Curso curso)
        {
            return dCurso.Modificar(curso);
        }

        public String Eliminar(int id)
        {
            return dCurso.Eliminar(id);
        }

        public List<Curso> ListarTodo()
        {
            return dCurso.ListarTodo();
        }
    }
}
