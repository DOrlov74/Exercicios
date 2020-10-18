using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DestritosAPI.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DestritosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreguesiasController : ControllerBase
    {
        private readonly DestritosAPIContext _context;

        public FreguesiasController(DestritosAPIContext context)
        {
            _context = context;
        }
        // GET: api/<FreguesiasController>
        [HttpGet]
        public IActionResult Get()
        {
            var freguesias = _context.Freguesias.ToList();
            return Ok(freguesias);
        }
        // GET: api/Freguesias/5
        [HttpGet("{id}")]
        public IActionResult GetFreguesias(int id)
        {
            var freguesias = _context.Freguesias.Where(f => f.ConselhoId == id).ToList();

            return Ok(freguesias);
        }
        // GET api/<FreguesiasController>/5/5
        //[HttpGet("{distrId}/{id}")]
        //public IEnumerable<string> Get(int distrId, int id)
        //{
        //    List<string> result = new List<string>();
        //    switch (distrId)
        //    {
        //        case 1:
        //        {
        //            switch (id)
        //            {
        //                case 1:
        //                {
        //                    result.Add("Beato");
        //                    result.Add("Campolide");
        //                }
        //                    break;
        //                case 2:
        //                {
        //                    result.Add("Cascais");
        //                    result.Add("Carcavelos");
        //                }
        //                    break;
        //                }
        //        };
        //            break;
        //        case 2:
        //            { 
        //            switch (id)
        //            {
        //                case 1:
        //                {
        //                    result.Add("BonFim");
        //                    result.Add("Campanhã");
        //                }
        //                    break;
        //                case 2:
        //                {
        //                    result.Add("Folgosa");
        //                    result.Add("Moreira");
        //                }
        //                    break;
        //            }
        //            break;
        //            }
        //    }
        //    return result;
        //}

        //// GET api/<FreguesiasController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<FreguesiasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FreguesiasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FreguesiasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
