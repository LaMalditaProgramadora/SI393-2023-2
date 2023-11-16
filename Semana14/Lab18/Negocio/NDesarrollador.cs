using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public  class NDesarrollador
    {
        private DDesarrollador dDesarrollador = new DDesarrollador();

        public String Registrar(Desarrollador desarrollador)
        {
            return dDesarrollador.Registrar(desarrollador);
        }

        public String Modificar(Desarrollador desarrollador)
        {
            return dDesarrollador.Modificar(desarrollador);
        }

        public String Eliminar(int id)
        {
            return dDesarrollador.Eliminar(id);
        }

        public List<Desarrollador> ListarTodo()
        {
            return dDesarrollador.ListarTodo();
        }
    }
}
