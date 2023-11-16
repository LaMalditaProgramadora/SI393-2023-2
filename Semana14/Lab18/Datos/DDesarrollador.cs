using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDesarrollador
    {
        public String Registrar(Desarrollador desarrollador)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Desarrollador.Add(desarrollador);
                    context.SaveChanges();
                }
                return "Registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Desarrollador desarrollador)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Desarrollador desarrolladorTemp = context.Desarrollador.Find(desarrollador.Id_Desarrollador);
                    desarrolladorTemp.Nombre = desarrollador.Nombre;
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
                    Desarrollador desarrolladorTemp = context.Desarrollador.Find(id);
                    context.Desarrollador.Remove(desarrolladorTemp);
                    context.SaveChanges();
                }
                return "Eliminado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Desarrollador> ListarTodo()
        {
            List<Desarrollador> desarrolladores = new List<Desarrollador>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    desarrolladores = context.Desarrollador.ToList();
                }
                return desarrolladores;
            }
            catch (Exception ex)
            {
                return desarrolladores;
            }
        }
    }
}
