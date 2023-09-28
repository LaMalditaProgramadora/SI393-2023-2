﻿using Lab12.entities;
using Lab12.repositories;

namespace Lab12.services
{
    internal class PacienteService
    {
        private PacienteRepository pacienteRepository = new();
            
        public PacienteService() { }

        public bool Registrar(String nroColegiatura, Paciente paciente)
        {
            if (pacienteRepository.Existe(paciente.Dni))
            {
                return false;
            }
            else
            {
                pacienteRepository.Registrar(nroColegiatura, paciente);
                return true;
            }
        }

        public List<Paciente> ListarTodo(String nroColegiatura)
        {
            return pacienteRepository.ListarTodo(nroColegiatura);
        }

        public List<Paciente> ListarPacientesPorEspecialidadDoctor(String especialidad)
        {
            return pacienteRepository.ListarPacientesPorEspecialidadDoctor(especialidad);
        }
    }
}
