using Dictionary.BLL.DTO;

using Dictionary.Infrastructure.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using AutoMapper;
using System.Linq;
using Dictionary.Domain.Interfaces;
using Dictionary.Domain.Core;

namespace Dictionary.BLL.Services
{
    public class EngEstService : IEngEstService//IGenericTranslateSerivce<TranslEngEst>
    {
        private UnitOfWork db = new UnitOfWork();
        //AutomapperConfiguration auto = new AutomapperConfiguration();
        

        public EngEstService()
        {
            
        }

        public IEnumerable<TranslEngEst> GetAll()
        {

             return db.TranslEngEsts.GetAll();// db.TranslEngEsts.GetAll();

        }

        public TranslEngEst GetByID(int id)
        {
            return  db.TranslEngEsts.GetByID(id);
        }

        public IEnumerable<TranslEngEst> Find(string word)
        {
            return db.TranslEngEsts.GetAll().Where(x=>x.EngWord.Word.Contains(word)||x.EstWord.Word.Contains(word));
        }

        public void Create(TranslEngEst item)
        {
            
            db.TranslEngEsts.Create(item);   
            
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
