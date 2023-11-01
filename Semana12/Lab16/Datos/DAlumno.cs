using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;

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
                return "Registrado correctamente";
            }
            catch (Exception ex)
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
                return "Modificado correctamente";
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
                    Alumno paisTemp = context.Alumno.Find(id);
                    context.Alumno.Remove(paisTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Alumno> ListarTodo()
        {
            try
            {
                List<Alumno> alumnos = new List<Alumno>();
                using (var context = new BDEFEntities())
                {
                    alumnos = context.Alumno.ToList();
                }
                return alumnos;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Alumno> ListarOrdenadoPorNotaFinalPC2()
        {
            try
            {
                List<Alumno> alumnos = new List<Alumno>();
                using (var context = new BDEFEntities())
                {
                    alumnos = context.Alumno.OrderBy(a => a.NotaFinalPC2).ToList();
                }
                return alumnos;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
