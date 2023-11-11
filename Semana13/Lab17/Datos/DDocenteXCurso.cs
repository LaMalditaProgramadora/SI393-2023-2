using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDocenteXCurso
    {
        public String Asignar(DocentexCurso docenteXCurso)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.DocentexCurso.Add(docenteXCurso);
                    context.SaveChanges();
                }
                return "Asignado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<DocentexCurso> ListarTodo()
        {
            List<DocentexCurso> docenteXCursos = new List<DocentexCurso>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    docenteXCursos = context.DocentexCurso.ToList();
                }
                return docenteXCursos;
            }
            catch (Exception ex)
            {
                return docenteXCursos;
            }
        }
    }
}
