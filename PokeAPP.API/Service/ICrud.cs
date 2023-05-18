using System;
namespace PokeAPP.API.Service
{
	public interface ICrud<T>
	{
		// CRUD
		public void Create(T obj);
		public T Read(int id);
		public IList<T> Listar();
		public void Update(int id, T obj);
		public void Delete(int id);
	}
}
