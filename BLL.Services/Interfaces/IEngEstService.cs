using Dictionary.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dictionary.BLL.Services
{
    public interface IEngEstService
    {
        IEnumerable<TranslEngEst> GetAll();
        TranslEngEst GetByID(int id);
        IEnumerable<TranslEngEst> Find(string word);
        void Create(TranslEngEst item);
        void Update(TranslEngEst item);
        void Delete(int id);
    }
}
