using Dictionary.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dictionary.BLL.Services
{
    public interface IEngEstService
    {
        IEnumerable<EngEstDTO> GetAll();
        EngEstDTO GetByID(int id);
        IEnumerable<EngEstDTO> Find(string word);
        void Create(EngEstDTO item);
        void Update(EngEstDTO item);
        void Delete(int id);
    }
}
