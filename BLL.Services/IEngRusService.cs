using Dictionary.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dictionary.BLL.Services
{
    public interface IEngRusService
    {

        IEnumerable<EngRusDTO> GetAll();
        EngRusDTO GetByID(int id);
        IEnumerable<EngRusDTO> Find(string word);
        void Create(EngRusDTO item);
        void Update(EngRusDTO item);
        void Delete(int id);

    }
}
