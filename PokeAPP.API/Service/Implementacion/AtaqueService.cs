using System;
using System.Data;
using PokeAPP.API.Models;

namespace PokeAPP.API.Service.Implementacion
{
	public class AtaqueService : IAtaque
    {
        static DBContext.Connection db = new DBContext.Connection();

        public AtaqueService(string conn)
		{
            db = new DBContext.Connection(conn);
		}

        public void Create(Ataque obj)
        {
            // insert into Ataque() values ();
            string query = string.Format(@"insert into Ataque(id_ataque, nombre, atq_damage, atq_pp, atq_precision) values ({0}, '{1}', {2}, {3}, {4})",
                obj.id_ataque, obj.Nombre, obj.damage, obj.PP, obj.precision
                );
            DataTable dt = db.Execute(query);
        }

        public void Delete(int id)
        {
            // delete from Ataque where id = id
            string query = string.Format(@"DELETE FROM Ataque WHERE id_ataque = {0}", id);
            DataTable dt = db.Execute(query);
        }

        public IList<Ataque> Listar()
        {
            string query = @"SELECT id_ataque, nombre, id_tipo, atq_pp, atq_damage, atq_precision FROM Ataque";
            DataTable dt = db.Execute(query);

            IList<Ataque> lista = new List<Ataque>();
            if (dt.Rows.Count > 0)
            {
                lista = (from DataRow rw in dt.Rows
                         select new Ataque()
                         {
                             id_ataque = Convert.ToInt32(rw["id_ataque"]),
                             Nombre = rw["Nombre"].ToString(),
                             damage = Convert.ToInt32(rw["atq_damage"]),
                             PP = Convert.ToInt32(rw["atq_pp"]),
                             precision = Convert.ToInt32(rw["atq_precision"])
                         }
                         ).ToList();
            }

            return lista;
        }

        public Ataque Read(int id)
        {
            string query = @"SELECT id_ataque, nombre, id_tipo, atq_pp, atq_damage, atq_precision FROM Ataque WHERE id_ataque = "+ id;
            DataTable dt = db.Execute(query);

            Ataque? obj = new Ataque();
            if (dt.Rows.Count > 0)
            {
                obj = (from DataRow rw in dt.Rows
                         select new Ataque()
                         {
                             id_ataque = Convert.ToInt32(rw["id_ataque"]),
                             Nombre = rw["Nombre"].ToString(),
                             damage = Convert.ToInt32(rw["atq_damage"]),
                             PP = Convert.ToInt32(rw["atq_pp"]),
                             precision = Convert.ToInt32(rw["atq_precision"])
                         }
                         ).FirstOrDefault();
            }

            return obj;
        }

        public void Update(int id, Ataque obj)
        {
            // Update ataque set (...) where id = id;
            string query = string.Format(@"UPDATE Ataque SET nombre = '{1}', atq_damage = {2}, atq_pp = {3}, atq_precision = {4} WHERE id_ataque = {0};",
                obj.id_ataque, obj.Nombre, obj.damage, obj.PP, obj.precision
                );
            DataTable dt = db.Execute(query);
        }
    }
}

