using Dictionary.Infrastructure.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Dictionary.Domain.Core;

namespace Dictionary.BLL.Services
{
    public class RusEstService: IGenericTranslateSerivce<TranslRusEst>
    {
        
        UnitOfWork db { get; set; }
        
        public RusEstService(UnitOfWork uow)
        {
            db = uow;
        }

        public IEnumerable<TranslRusEst> GetAll()
        {
            return db.TranslRusEsts.GetAll();// db.TranslRusEsts.GetAll();
        }

        public TranslRusEst GetByID(int id)
        {
            return db.TranslRusEsts.GetByID(id);
        }

        public IEnumerable<TranslRusEst> Find(string word)
        {
            return db.TranslRusEsts.GetAll().Where(x => x.RusWord.Word.Contains(word) || x.EstWord.Word.Contains(word));
        }

        public void Create(TranslRusEst item)
        {
            db.TranslRusEsts.Create(item);
        }

        public void Update(TranslRusEst item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}


