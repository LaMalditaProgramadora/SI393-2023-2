using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DVideojuego
    {
        public String Registrar(Videojuego videojuego)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Videojuego.Add(videojuego);
                    context.SaveChanges();
                }
                return "Registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Videojuego videojuego)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Videojuego videojuegoTemp = context.Videojuego.Find(videojuego.Id_Videojuego);
                    videojuegoTemp.Titulo = videojuego.Titulo;
                    videojuegoTemp.Valoracion = videojuego.Valoracion;
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
                    Videojuego videojuegoTemp = context.Videojuego.Find(id);
                    context.Videojuego.Remove(videojuegoTemp);
                    context.SaveChanges();
                }
                return "Eliminado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Videojuego> ListarTodo()
        {
            List<Videojuego> videojuegos = new List<Videojuego>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    videojuegos = context.Videojuego.ToList();
                }
                return videojuegos;
            }
            catch (Exception ex)
            {
                return videojuegos;
            }
        }

        public List<Videojuego> ListarTodoPorValoracion(int valoracion)
        {
            List<Videojuego> videojuegos = new List<Videojuego>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    videojuegos = context.Videojuego.Where(v => v.Valoracion == valoracion).ToList();
                }
                return videojuegos;
            }
            catch (Exception ex)
            {
                return videojuegos;
            }
        }
    }
}
