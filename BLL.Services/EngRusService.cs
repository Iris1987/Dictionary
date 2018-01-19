using Dictionary.Domain.Core;
using Dictionary.Infrastructure.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary.BLL.Services
{
    public class EngRusService : IGenericTranslateSerivce<TranslEngRus>
    {



        UnitOfWork db { get; set; }
        //AutomapperConfiguration auto = new AutomapperConfiguration();


        public EngRusService(UnitOfWork uow)
        {
            db = uow;
        }

        public IEnumerable<TranslEngRus> GetAll()
        {

            return db.TranslEngRuses.GetAll();
            
        }

        public TranslEngRus GetByID(int id)
        {
            return db.TranslEngRuses.GetByID(id);
        }

        public IEnumerable<TranslEngRus> Find(string word)
        {
            
            return  db.TranslEngRuses.GetAll().Where(x => x.EngWord.Word.Contains(word) || x.RusWord.Word.Contains(word));
            
        }

        public void Create(TranslEngRus item)
        {

            db.TranslEngRuses.Create(item);
          
        }

        public void Update(TranslEngRus item)
        {

            throw new NotImplementedException();



        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
