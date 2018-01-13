using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace WebApi.Controllers
{
    


    [Produces("application/json")]
    [Route("api/EngEst")]
    public class EngEstController : Controller
    {
        
        // GET: api/EngEst
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/EngEst/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "x" ;
        }
        
        // POST: api/EngEst
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/EngEst/5
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
