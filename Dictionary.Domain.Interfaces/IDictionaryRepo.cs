using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dictionary.Domain.Core;

namespace Dictionary.Domain.Interfaces
{
   public interface IDictionaryRepo<TEntity> where TEntity: class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetByID(int id);
        void Create(TEntity item);
        void Update(TEntity item);
        void Delete(int id);
        //void Save();












        //IEnumerable<TEntity> GetAll();
        //// IQueryable<TEntity> GetAll { get; }
        //// IList<T> GetAll();
        // TEntity GetByID(int id);
        // Task Create(TEntity item);
        // Task Update(TEntity item);
        // Task Delete(int id);
        // void Save();

    }
    ///with generic repository
    //public interface IDictionaryRepository<T> where T : class
    //{
    //    //IEnumerable<T> GetAll();
    //IList<T> GetAll();
    //T GetByID(int id);
    //void Create(T item);
    //void Update(T item);
    //void Delete(int id);
    //void Save();
    //}

    //public class GenericRepository<T> : IRepository<T> where T : class
    //{
    //    private readonly DbContext _dbContext;
    //    private IDbSet<T> _dbSet => _dbContext.Set<T>();
    //    public IQueryable<T> Entities => _dbSet;
    //    public GenericRepository(MyDbContext dbContext)
    //    {
    //        _dbContext = dbContext;
    //    }
    //    public void Remove(T entity)
    //    {
    //        _dbSet.Remove(entity);
    //    }
    //    public void Add(T entity)
    //    {
    //        _dbSet.Add(entity);
    //    }
    //}
}
