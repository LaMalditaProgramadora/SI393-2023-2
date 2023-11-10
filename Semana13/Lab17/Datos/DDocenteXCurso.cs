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
                return "Agregado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<DocentexCurso> ListarTodo()
        {
            List<DocentexCurso> docenteXCurso = new List<DocentexCurso>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    docenteXCurso = context.DocentexCurso.ToList();
                }
                return docenteXCurso;
            }
            catch (Exception ex)
            {
                return docenteXCurso;
            }
        }
    }
}
