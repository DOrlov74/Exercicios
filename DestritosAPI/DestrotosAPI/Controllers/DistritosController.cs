using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DestritosAPI.Data;
using DestritosAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DestritosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistritosController : ControllerBase
    {
        private readonly DestritosAPIContext _context;

        public DistritosController(DestritosAPIContext context)
        {
            _context = context;
        }
        // GET: api/<DistritosController>
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "Lisboa", "Porto" };
        //}
        public IActionResult GetDistritos()
        {
            return Ok(_context.Distritos.ToList());
        }

        // GET api/<DistritosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DistritosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DistritosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DistritosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
