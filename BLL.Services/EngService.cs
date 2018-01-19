using Dictionary.Domain.Core;
using Dictionary.Infrastructure.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.BLL.Services
{
    public class EngService:IGenGetAllSerivce<EngLang>
    {

        UnitOfWork db { get; set; }



        public EngService(UnitOfWork uow)
        {
            db = uow;
        }

        public IEnumerable<EngLang> GetAll()
        {
            return db.EngLangs.GetAll();
        }

    }
}
