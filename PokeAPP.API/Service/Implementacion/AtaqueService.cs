using System;
using PokeAPP.API.Models;

namespace PokeAPP.API.Service.Implementacion
{
	public class AtaqueService : IAtaque
    {
        static IList<Ataque> lista = new List<Ataque>();

        public AtaqueService()
		{
            if (lista.Count == 0)
            {
                lista.Add(
                    new Ataque
                    {
                        id_ataque = 1,
                        Nombre = "Placaje",
                        precision = 100,
                        PP = 30,
                        damage = 35,
                        tipo = new Tipo
                        {
                            id_tipo = 1,
                            nombreTipo = "Normal"
                        }
                    }
                );
            }
		}

        public void Create(Ataque obj)
        {
            // insert into Ataque() values ();
            lista.Add(obj);
        }

        public void Delete(int id)
        {
            // delete from Ataque where id = id
            lista.Remove(lista.First(x => x.id_ataque == id));
        }

        public IList<Ataque> Listar()
        {
            // select * from Ataque;
            return lista;
        }

        public Ataque Read(int id)
        {
            // select * from Ataque where id = id;
            return lista.FirstOrDefault(x => x.id_ataque == id);
        }

        public void Update(int id, Ataque obj)
        {
            // Update ataque set (...) where id = id;
            obj.id_ataque = id;
            lista.Insert(
                lista.IndexOf(
                    lista.First(x => x.id_ataque == id)),
                obj
            );
        }
    }
}

