using Microsoft.AspNetCore.Mvc;
using Nursery.Core.Models;
using Nursery.Core.Services;
using Nursery.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nursery.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnsController : ControllerBase
    {
        private readonly ITurnService _turnService;

        public TurnsController(ITurnService turnService)
        {
            _turnService = turnService;
        }
        // GET: api/<Turns>
        [HttpGet]
        public IEnumerable<Turn> Get()
        {
            return _turnService.GetAll();
        }

        // GET api/<Turns>/5
        [HttpGet("{id}")]
        public Turn Get(int id)
        {
           return _turnService.GetT(id);
        }

        // POST api/<Turns>
        [HttpPost]
        public ActionResult Post([FromBody] Turn turn)
        {
            return Ok(_turnService.AddT(turn));
        }

        // PUT api/<Turns>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Turn turn)
        {
            return Ok(_turnService.PutT(id,turn));
        }

        // DELETE api/<Turns>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var turn = _turnService.GetT(id);
            if (turn is null)
            {
                return NotFound();
            }
            _turnService.DeleteT(id);
            return NoContent();
        }
    }
}
