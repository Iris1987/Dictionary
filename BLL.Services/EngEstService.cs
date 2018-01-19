using Dictionary.BLL.DTO;

using Dictionary.Infrastructure.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using AutoMapper;
using System.Linq;
using Dictionary.Domain.Core;

namespace Dictionary.BLL.Services
{
    public class EngEstService : IEngEstService//IGenericTranslateSerivce<TranslEngEst>
    {
        
       

        UnitOfWork db { get; set; }
        //AutomapperConfiguration auto = new AutomapperConfiguration();
        

        public EngEstService(UnitOfWork uow)
        {
            db = uow;
        }

        public IEnumerable<TranslEngEst> GetAll()
        {

             return db.TranslEngEsts.GetAll();// db.TranslEngEsts.GetAll();

            

        }

        public TranslEngEst GetByID(int id)
        {
            return db.TranslEngEsts.GetByID(id);
        }

        public IEnumerable<TranslEngEst> Find(string word)
        {
            return db.TranslEngEsts.GetAll().Where(x=>x.EngWord.Word.Contains(word)||x.EstWord.Word.Contains(word));
        }

        public void Create(TranslEngEst item)
        {
            
            db.TranslEngEsts.Create(item);   
            //var xxx = Mapper.Map<TranslEngEst,TranslEngEst>

            //Mapper.Map<TranslEngEst>(db.TranslEngEsts.  db.TranslEngEsts.Create(
            //    item.Category,
            //    item.EngWord,
            //    item.EstWord,
            //    item.Example,
            //    item.ID,/*??*/
            //    item.PartOfSpeech,
            //    item.Subcategory));

            //var currentEmployer = DAL.Employers.Get(Person.Employer.EmployerID);
            //if (currentEmployer != person.Employer)
            //{
            //    // Try and get a matching Employer from the appropriate Service (liaising with the DAL)
            //    var employer = EmployerManager.GetEmployer(person.Employer.EmployerID);
            //    if (employer == null)
            //    {
            //        // ... Create a new employer
            //    }
            //    else if (employer != person.Employer)
            //    {
            //        // ... Update existing employer
            //    }
            //}


        }

        public void Update(TranslEngEst item)
        {

            db.TranslEngEsts.Update(item);



        }

        public void Delete(int id)
        {
            db.TranslEngEsts.Delete(id);
        }
    }
}
