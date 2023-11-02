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
            // Lógica de Negocio
            alumno.NotaFinalPC2 = alumno.PromedioTA * (decimal)0.2 + alumno.PC2 * (decimal)0.8;
            return dAlumno.Registrar(alumno);
        }

        public String Modificar(Alumno alumno)
        {
            // Lógica de Negocio
            alumno.NotaFinalPC2 = alumno.PromedioTA * (decimal)0.2 + alumno.PC2 * (decimal)0.8;
            return dAlumno.Modificar(alumno);
        }

        public String Elimnar(int id)
        {
            return dAlumno.Elimnar(id);
        }

        public List<Alumno> ListarTodo()
        {
            return dAlumno.ListarTodo();
        }

        public List<Alumno> ListarTodoOrdenadoPorNotaFinalPC2()
        {
            return dAlumno.ListarTodoOrdenadoPorNotaFinalPC2();
        }

    }
}
