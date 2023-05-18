using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using PokeAPP.API.Service;
using PokeAPP.API.Models;
using PokeAPP.API.Service.Implementacion;

namespace PokeAPP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        ICrud<Pokemon> service = new PokemonService();

        // GET: api/Pokemon
        [HttpGet]
        public IList<Pokemon> Get()
        {
            return service.Listar();
        }

        // GET: api/Pokemon/5
        [HttpGet("{id}", Name = "Get")]
        public Pokemon Get(int id)
        {
            return service.Read(id);
        }

        // POST: api/Pokemon
        [HttpPost]
        public void Post([FromBody] Pokemon value)
        {
            service.Create(value);
        }

        // PUT: api/Pokemon/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pokemon value)
        {
            service.Update(id, value);
        }

        // DELETE: api/Pokemon/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
