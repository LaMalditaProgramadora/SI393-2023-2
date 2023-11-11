using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public  class DCurso
    {
        public String Registrar(Curso curso)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Curso.Add(curso);
                    context.SaveChanges();
                }
                return "Registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Curso curso)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Curso cursoTemp = context.Curso.Find(curso.Id_curso);
                    cursoTemp.Nombrecurso = curso.Nombrecurso;
                    context.SaveChanges();
                }
                return "Modificado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int id)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Curso cursoTemp = context.Curso.Find(id);
                    context.Curso.Remove(cursoTemp);
                    context.SaveChanges();
                }
                return "Eliminado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Curso> ListarTodo()
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    cursos = context.Curso.ToList();
                }
                return cursos;
            }
            catch (Exception ex)
            {
                return cursos;
            }
        }

    }
}
