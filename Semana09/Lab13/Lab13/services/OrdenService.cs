using Lab13.entities;
using Lab13.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.services
{
    internal class OrdenService
    {
        private OrdenRepository oRepository = new OrdenRepository();
        public OrdenService() { }

        public bool Registrar(String placa, Orden orden)
        {
            if (oRepository.Existe(orden.Codigo))
            {
                return false;
            }
            else
            {
                oRepository.Registrar(placa, orden);
                return true;
            }
        }

        public List<Orden> ListarTodo(String placa)
        {
            return oRepository.ListarTodo(placa);
        }
    }
}
