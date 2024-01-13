using Microsoft.AspNetCore.Mvc;
using Nursery.Core.Models;
using Nursery.Core.Services;
using Nursery.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nursery.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NursesController : ControllerBase
    {
        private readonly INurseService _nurseService;

        public NursesController(INurseService nurseService)
        {
            _nurseService= nurseService;
        }
        // GET: api/<Nurses>
        [HttpGet]
        public IEnumerable<Nurse> Get()
        {
            return _nurseService.GetAll();
        }

        // GET api/<Nurses>/5
        [HttpGet("{id}")]
        public Nurse Get(int id)
        {
            return _nurseService.GetN(id);
        }

        // POST api/<Nurses>
        [HttpPost]
        public ActionResult Post([FromBody] Nurse nurse)
        {
            return Ok(_nurseService.AddN(nurse));
        }

        // PUT api/<Nurses>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Nurse nurse)
        {
            return Ok(_nurseService.PutN(id, nurse));
        }

        // DELETE api/<Nurses>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
           
            var nurse = _nurseService.GetN(id);
            if (nurse is null)
            {
                return NotFound();
            }
            _nurseService.DeleteN(id);
            return NoContent();
        }
    }
}
