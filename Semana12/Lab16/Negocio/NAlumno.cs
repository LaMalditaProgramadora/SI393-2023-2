using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAlumno
    {
        private DAlumno dAlumno = new DAlumno();
        public NAlumno() { }

        public String Registrar(Alumno alumno)
        {
            // Lógica del negocio
            alumno.NotaFinalPC2 = alumno.PromedioTA * (decimal) 0.2 + alumno.PC2 * (decimal) 0.8;
            return dAlumno.Registrar(alumno);
        }

        public String Eliminar(int id)
        {
            return dAlumno.Eliminar(id);
        }

        public List<Alumno> ListarTodo()
        {
            return dAlumno.ListarTodo();
        }

        public List<Alumno> ListarOrdenadoPorNotaFinalPC2()
        {
            return dAlumno.ListarOrdenadoPorNotaFinalPC2();
        }
    }
}
