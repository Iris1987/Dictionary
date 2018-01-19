using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.BLL.Services
{
    public interface IGenericTranslateSerivce<TEntity> where TEntity: class
    {

        IEnumerable<TEntity> GetAll();
        TEntity GetByID(int id);
        IEnumerable<TEntity> Find(string word);
        void Create(TEntity item);
        void Update(TEntity item);
        void Delete(int id);

    }
}
