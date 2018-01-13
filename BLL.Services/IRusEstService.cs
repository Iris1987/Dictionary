using Dictionary.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dictionary.BLL.Services
{
    public interface IRusEstService
    {

        IEnumerable<RusEstDTO> GetAll();
        RusEstDTO GetByID(int id);
        IEnumerable<RusEstDTO> Find(string word);
        void Create(RusEstDTO item);
        void Update(RusEstDTO item);
        void Delete(int id);

    }
}
