using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NDocenteXCurso
    {
        private DDocenteXCurso dDocenteXCurso = new DDocenteXCurso();

        public String Asignar(DocentexCurso docenteXCurso)
        {
            return dDocenteXCurso.Asignar(docenteXCurso);
        }

        public List<DocentexCurso> ListarTodo()
        {
            return dDocenteXCurso.ListarTodo();
        }
    }
}
