using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NVideojuego
    {
        private DVideojuego dVideojuego = new DVideojuego();

        public String Registrar(Videojuego videojuego)
        {
            return dVideojuego.Registrar(videojuego);
        }

        public String Modificar(Videojuego videojuego)
        {
            return dVideojuego.Modificar(videojuego);
        }

        public String Eliminar(int id)
        {
            return dVideojuego.Eliminar(id);
        }

        public List<Videojuego> ListarTodo()
        {
            return dVideojuego.ListarTodo();
        }

        public List<Videojuego> ListarTodoPorValoracion(int valoracion)
        {
            return dVideojuego.ListarTodoPorValoracion(valoracion);
        }
    }
}
