using System;
using PokeAPP.API.Models;
namespace PokeAPP.API.Service.Implementacion
{
	public class PokemonService : ICrud<Pokemon>
	{
        static IList<Pokemon> lista = new List<Pokemon>();

		public PokemonService()
		{
            lista.Add(new Pokemon
            {
                id_pokemon = 1,
                nombre = "Bulbasaur",
                peso = 6900,
                estatura = 70,
                sexo = Sexualida.Macho,
                isShiny = false
            });
		}

        public void Create(Pokemon obj)
        {
            lista.Add(obj);
        }

        public void Delete(int id)
        {
            lista.Remove(lista.First(x => x.id_pokemon == id));
        }

        public IList<Pokemon> Listar()
        {
            return lista;
        }

        public Pokemon Read(int id)
        {
            return lista.FirstOrDefault(x => x.id_pokemon == id);
        }

        public void Update(int id, Pokemon obj)
        {
            // Update ataque set (...) where id = id;
            obj.id_pokemon = id;
            lista.Insert(
                lista.IndexOf(
                    lista.First(x => x.id_pokemon == id)),
                obj
            );
        }
    }
}

