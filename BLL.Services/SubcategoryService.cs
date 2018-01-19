using Dictionary.Domain.Core;
using Dictionary.Infrastructure.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.BLL.Services
{
    public class SubcategoryService : IGenGetAllSerivce<Subcategory>
    {

        UnitOfWork db { get; set; }
        


        public SubcategoryService(UnitOfWork uow)
        {
            db = uow;
        }

        public IEnumerable<Subcategory> GetAll()
        {
            return db.Subcategories.GetAll();
        }
    }
}
