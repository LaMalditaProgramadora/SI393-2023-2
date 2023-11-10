using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DDocente
    {
        public DDocente() { }

        public String Registrar(Docente docente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Docente.Add(docente);
                    context.SaveChanges();
                }
                return "Registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Docente docente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Docente docenteTemp = context.Docente.Find(docente.Id_docente);
                    docenteTemp.Nombre = docente.Nombre;
                    docenteTemp.Apellido = docente.Apellido;
                    docenteTemp.Escuela = docente.Escuela;
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
                    Docente docenteTemp = context.Docente.Find(id);
                    context.Docente.Remove(docenteTemp);
                    context.SaveChanges();
                }
                return "Eliminado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Docente> ListarTodo()
        {
            List<Docente> docentes = new List<Docente>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    docentes = context.Docente.ToList();
                }
                return docentes;
            }
            catch (Exception ex)
            {
                return docentes;
            }
        }

        public List<Docente> ListarTodoPorEscuela(String escuela)
        {
            List<Docente> docentes = new List<Docente>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    docentes = context.Docente.Where(d => d.Escuela.Equals(escuela)).ToList();
                }
                return docentes;
            }
            catch (Exception ex)
            {
                return docentes;
            }
        }
    }
}
