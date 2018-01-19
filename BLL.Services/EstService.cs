using Dictionary.Domain.Core;
using Dictionary.Infrastructure.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.BLL.Services
{
    public class EstService : IGenGetAllSerivce<EstLang>
    {

        UnitOfWork db { get; set; }



        public EstService(UnitOfWork uow)
        {
            db = uow;
        }

        public IEnumerable<EstLang> GetAll()
        {
            return db.EstLangs.GetAll();
        }

    }
}
