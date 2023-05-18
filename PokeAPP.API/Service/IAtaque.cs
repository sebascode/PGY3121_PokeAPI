using System;
using PokeAPP.API.Models;

namespace PokeAPP.API.Service
{
	public interface IAtaque
	{
		// CRUD
		public void Create(Ataque obj);
		public Ataque Read(int id);
		public IList<Ataque> Listar();
		public void Update(int id, Ataque obj);
		public void Delete(int id);
	}
}

