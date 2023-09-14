using Lab09.entities;
using Lab09.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09.services
{
    internal class PokemonService
    {
        private PokemonRepository pokemonRepository = new();
        public PokemonService() { }

        public bool Insertar(String codidoEntrenador, Pokemon pokemon)
        {
            if (!pokemonRepository.Existe(pokemon.Codigo))
            {
                pokemonRepository.Insertar(codidoEntrenador, pokemon);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Pokemon> ListarPorEntrenador(String codigoEntrenador)
        {
            return pokemonRepository.ListarPorEntrenador(codigoEntrenador);
        }
    }
}
