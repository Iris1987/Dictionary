using Dictionary.Domain.Core;
using Dictionary.Infrastructure.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.BLL.Services
{
    public class RusService : IGenGetAllSerivce<RusLang>
    {

        UnitOfWork db { get; set; }



        public RusService(UnitOfWork uow)
        {
            db = uow;
        }

        public IEnumerable<RusLang> GetAll()
        {
            return db.RusLangs.GetAll();
        }

    }
}
