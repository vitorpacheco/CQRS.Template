using CQRS.Template.Application.Features.People.Queries;
using CQRS.Template.Application.Features.People.Queries.SeedWork;
using CQRS.Template.Domain.QueryMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CQRS.Template.Api.Controllers.v1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PersonController : BaseController
    {
        // GET: api/<PersonController>
        [HttpGet]
        public async Task<IEnumerable<PersonDto>> Get([FromQuery] QueryOptions options)
        {
            return await Mediator.Send(new GetPeopleQuery
            {
                QueryOptions = options
            });
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
