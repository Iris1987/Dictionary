using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Dictionary.BLL.DTO;
using Dictionary.BLL.Services;
using Dictionary.Domain.Interfaces;
using Dictionary.Domain.Core;
using Dictionary.Infrastructure.Data.UnitOfWork;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/EngEst")]
    public class EngEstController: Controller
    {

        private UnitOfWork unitOfWork = new UnitOfWork();


        private readonly IEngEstService tService;
        //private readonly IGenGetAllSerivce<EngEstDTO> getAll;


        private readonly IMapper mapper;

        //private readonly IUnitOfWork uow;

        public EngEstController(IMapper mapper,  IEngEstService tService)
        {
          //  this.uow = uow;
            this.mapper = mapper;
            this.tService = tService;

        }

        //IEnumerable<TranslEngEst> GetAll();
        //TranslEngEst GetByID(int id);
        //IEnumerable<TranslEngEst> Find(string word);
        //void Create(TranslEngEst item);
        //void Update(TranslEngEst item);
        //void Delete(int id);



            //ne znaju kakoj iz dvuh pravelnyj

        [HttpGet("{id}", Name = "GetById")]
        public EngEstDTO GetById(int id)
        {
            var so = tService.GetByID(id);
            var soso = mapper.Map< TranslEngEst,EngEstDTO> (so);
            return soso;

        }

        //[HttpGet("{id}", Name = "Get")]
        //public EngEstDTO GetByID(int id)
        //{
        //    var xxx = tService.GetByID(id);
        //    var yy = uow.TranslEngEsts.GetByID(id);// Where(xx=>xx.ID=id).Single();
        //    var model = mapper.Map<TranslEngEst, EngEstDTO>(xxx);

        //    return model;

        //}


        [HttpGet(Name = "GetAll")]
        public IEnumerable<EngEstDTO> GetAll()
        {
            var xx = tService.GetAll();
           // var xxx = uow.TranslEngEsts.GetAll();
           // var yy = mapper.Map<TranslEngEst, EngEstDTO>(xx);

            

            return mapper.Map<IEnumerable<EngEstDTO>>(xx); 

        }


        //// GET: api/EngEst
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/EngEst/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        
        // POST: api/EngEst
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] EngEstDTO dto )
        //public void Post([FromBody]string value)
        {
            var model = mapper.Map<TranslEngEst>(dto);
            if (model == null) return NotFound();
            
            return Ok(model);//mapper.Map<TranslEngEst, EngEstDTO>(xx);

        }
        



        //// PUT: api/EngEst/5
        //[HttpPut("{id}")]
        //public void Update(EngEstDTO value)
        //{
        //    var xx = uow.TranslEngEsts.Create(value);
        //    var yy = tService.Update());
        //    var model = mapper.Map<TranslEngEst, EngEstDTO>(xx);

        //}
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}",Name ="Delete")]
        public void Delete(int id)
        {
            tService.Delete(id);
        }
    }
}
