using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAlumno
    {
        public DAlumno() { }

        public String Registrar(Alumno alumno)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Alumno.Add(alumno);
                    context.SaveChanges();
                }
                return "Registrado exitosamente";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Alumno alumno)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Alumno alumnoTemp = context.Alumno.Find(alumno.Id);
                    alumnoTemp.Codigo = alumno.Codigo;
                    alumnoTemp.NombreCompleto = alumno.NombreCompleto;
                    alumnoTemp.PromedioTA = alumno.PromedioTA;
                    alumnoTemp.PC2 = alumno.PC2;
                    alumnoTemp.NotaFinalPC2 = alumno.NotaFinalPC2;
                    context.SaveChanges();
                }
                return "Modificado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Elimnar(int id)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Alumno alumnoTemp = context.Alumno.Find(id);
                    context.Alumno.Remove(alumnoTemp);
                    context.SaveChanges();
                }
                return "Eliminaado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Alumno> ListarTodo()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    alumnos = context.Alumno.ToList();
                }
                return alumnos;
            }
            catch (Exception ex)
            {
                return alumnos;
            }
        }

        public List<Alumno> ListarTodoOrdenadoPorNotaFinalPC2()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    alumnos = context.Alumno.OrderBy(a => a.NotaFinalPC2).ToList();
                }
                return alumnos;
            }
            catch (Exception ex)
            {
                return alumnos;
            }
        }

        public List<Alumno> ListarTodoBuscarPorCodigo(String codigo)
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    alumnos = context.Alumno.Where(a => a.Codigo.Equals(codigo)).ToList();
                }
                return alumnos;
            }
            catch (Exception ex)
            {
                return alumnos;
            }
        }
    }
}
