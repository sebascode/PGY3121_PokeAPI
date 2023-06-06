using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeAPP.API.DBContext;
using PokeAPP.API.Models;
using PokeAPP.API.Service;
using PokeAPP.API.Service.Implementacion;

namespace PokeAPP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtaqueController : ControllerBase
    {
        static IAtaque servicio;

        public AtaqueController(IConfiguration configuration)
        {
            string conn = configuration.GetConnectionString("oci");
            servicio = new AtaqueService(conn);
        }

        // GET: api/Ataque
        [HttpGet]
        public IList<Ataque> GetAtaques()
        {
            return servicio.Listar();
        }

        // GET: api/Ataque/5
        [HttpGet("{id}", Name = "GetAtaque")]
        public Ataque GetAtaque(int id)
        {
            return servicio.Read(id);
        }

        // POST: api/Ataque
        [HttpPost]
        public void PostAtaque([FromBody] Ataque objeto)
        {
            servicio.Create(objeto);
        }

        // PUT: api/Ataque/5
        [HttpPut("{id}")]
        public void PutAtaque(int id, [FromBody] Ataque value)
        {
            ModelState.Remove("tipo");
            Console.WriteLine("Comenzando proceso");
            if (ModelState.IsValid)
            {
                Console.WriteLine("Modelo es válido");
                servicio.Update(id, value);
            }
            else
                Console.WriteLine("No es válido");
        }

        // DELETE: api/Ataque/5
        [HttpDelete("{id}")]
        public void DeleteAtaque(int id)
        {
            servicio.Delete(id);
        }
    }
}
