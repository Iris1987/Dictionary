using Dictionary.Domain.Core;
using Dictionary.Infrastructure.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.BLL.Services
{
    public class CategoryService: IGenGetAllSerivce<Category>
    {

        UnitOfWork db { get; set; }



        public CategoryService(UnitOfWork uow)
        {
            db = uow;
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.GetAll();
        }

    }
}
