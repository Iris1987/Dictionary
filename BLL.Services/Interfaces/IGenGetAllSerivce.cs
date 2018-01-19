using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.BLL.Services
{
    public interface IGenGetAllSerivce<TEntity> where TEntity: class
    {

        IEnumerable<TEntity> GetAll();

    }
}
