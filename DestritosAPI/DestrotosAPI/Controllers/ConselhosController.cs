using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DestritosAPI.Data;
using DestritosAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DestritosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConselhosController : ControllerBase
    {
        private readonly DestritosAPIContext _context;

        public ConselhosController(DestritosAPIContext context)
        {
            _context = context;
        }
        // GET: api/<ConselhosController>
        [HttpGet]
        public IActionResult Get()
        {
            var conselhos = _context.Conselhos.ToList();
            return Ok(conselhos);
        }
        // GET: api/Conselhos/5
        [HttpGet("{id}")]
        public IActionResult GetConselhos(int id)
        {
            var conselhos = _context.Conselhos.Where(c=>c.DistritoId==id).ToList();

            return Ok(conselhos);
        }
        // GET: api/<ConselhosController>
        //[HttpGet("{id}")]
        //public IEnumerable<string> Get(int id)
        //{
        //    List<string> result=new List<string>();
        //    switch (id)
        //    {
        //        case 1:
        //        {
        //            result.Add("Lisboa");
        //            result.Add("Cascais");
        //        };
        //            break;
        //        case 2:
        //            result.Add("Porto");
        //            result.Add("Maia");
        //            break;

        //    }
        //    return result;
        //}

        //// GET api/<ConselhosController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<ConselhosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ConselhosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ConselhosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
