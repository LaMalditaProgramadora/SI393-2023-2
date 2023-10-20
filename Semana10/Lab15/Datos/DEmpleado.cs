﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEmpleado
    {
        private static List<EEmpleado> empleados = new List<EEmpleado>();
        public DEmpleado() { }

        public bool Existe(String dni)
        {
            return empleados.Exists(e => e.Dni.Equals(dni));
        }

        public void Registrar(EEmpleado empleado)
        {
            empleados.Add(empleado);
        }

        public void Eliminar(String dni)
        {
            empleados.RemoveAll(e => e.Dni.Equals(dni));
        }

        public static List<EEmpleado> ListarTodo()
        {
            return empleados;
        }

        public List<EEmpleado> ListarOrdenadoPorSueldo()
        {
            return empleados.OrderBy(e => e.Sueldo).ToList();
        }
    }
}
