using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeAPP.API.Models;
using PokeAPP.API.Service;
using PokeAPP.API.Service.Implementacion;

namespace PokeAPP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtaqueController : ControllerBase
    {
        IAtaque servicio = new AtaqueService();

        // GET: api/Ataque
        [HttpGet]
        public IList<Ataque> Get()
        {
            return servicio.Listar();
        }

        // GET: api/Ataque/5
        [HttpGet("{id}", Name = "Get")]
        public Ataque Get(int id)
        {
            return servicio.Read(id);
        }

        // POST: api/Ataque
        [HttpPost]
        public void Post([FromBody] Ataque objeto)
        {
            servicio.Create(objeto);
        }

        // PUT: api/Ataque/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Ataque value)
        {
            servicio.Update(id, value);
        }

        // DELETE: api/Ataque/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            servicio.Delete(id);
        }
    }
}
