using Dictionary.BLL.DTO;
using Dictionary.Infrastructure.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using AutoMapper;
using System.Linq;

namespace Dictionary.BLL.Services
{
    public class EngEstService : IEngEstService
    {
        
        UnitOfWork db { get; set; }
        //AutomapperConfiguration auto = new AutomapperConfiguration();
        

        public EngEstService(UnitOfWork uow)
        {
            db = uow;
        }

        public IEnumerable<EngEstDTO> GetAll()
        {
           
            return Mapper.Map<IEnumerable<EngEstDTO>>(db.TranslEngEsts.GetAll());// db.TranslEngEsts.GetAll();
        }

        public EngEstDTO GetByID(int id)
        {
            return Mapper.Map<EngEstDTO>(db.TranslEngEsts.GetByID(id));
        }

        public IEnumerable<EngEstDTO> Find(string word)
        {
            return Mapper.Map<IEnumerable<EngEstDTO>>(db.TranslEngEsts.GetAll().Where(x=>x.EngWord.Word.Contains(word)||x.EstWord.Word.Contains(word)));
        }

        public void Create(EngEstDTO item)
        {

            Mapper.Map<EngEstDTO>(db.TranslEngEsts.Create(item));



        }

        public void Update(EngEstDTO item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
