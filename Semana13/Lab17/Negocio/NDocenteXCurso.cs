using Datos;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class NDocenteXCurso
    {
        private DDocenteXCurso dDocenteXCurso = new DDocenteXCurso();
        public NDocenteXCurso() { }

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
