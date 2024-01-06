using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nursery.Core.Models;
using Nursery.Core.Services;
using Nursery.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nursery.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BabiesController : ControllerBase
    {
        private readonly IBabyService _babyService;

        public BabiesController(IBabyService babyService)
        {
            _babyService = babyService;
        }

        // GET: api/<BabiesController>
        [HttpGet]
        public IEnumerable<Baby> Get()
        {
            return _babyService.GetAll();
        }

        // GET api/<BabiesController>/5
        [HttpGet("{id}")]
        public Baby Get(int id)
        {
           return _babyService.GetB(id);
        }

        // POST api/<BabiesController>
        [HttpPost]
        public Baby Post([FromBody] Baby baby)
        {

            _babyService.AddB(baby);
            return baby;
        }
        //PUT api/<BabiesController>/5
        [HttpPut("{id}")]
        public Baby Put(int id, [FromBody] Baby baby)
        {
            return _babyService.PutB(id, baby);
        }

        // DELETE api/<BabiesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _babyService.DeleteB(id);
        }
    }
}
