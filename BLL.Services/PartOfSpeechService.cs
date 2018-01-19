using Dictionary.Domain.Core;
using Dictionary.Infrastructure.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.BLL.Services
{
    public class PartOfSpeechService:IGenGetAllSerivce<PartOfSpeech>
    {

        UnitOfWork db { get; set; }



        public PartOfSpeechService(UnitOfWork uow)
        {
            db = uow;
        }

        public IEnumerable<PartOfSpeech> GetAll()
        {
            return db.PartsOfSpeech.GetAll();
        }

    }
}
