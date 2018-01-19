using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dictionary.BLL.Services;
using Dictionary.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/ControllerEngEst")]
    public class ControllerEngEstController : Controller
    {

        private readonly IEngEstService enEeService;

        private readonly IUnitOfWork uow;

        private readonly IMapper mapper;

        public ControllerEngEstController(IMapper mapper)
        {

            this.mapper = mapper;

        }



        // GET: api/ControllerEngEst
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ControllerEngEst/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/ControllerEngEst
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/ControllerEngEst/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
