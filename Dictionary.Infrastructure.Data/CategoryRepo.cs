using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dictionary.Domain.Core;
using Dictionary.Domain.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace Dictionary.Infrastructure.Data
{
    public class CategoryRepo: IDictionaryRepo<Category>, ISearch<CategoryRepo>
    {

        private Context db;

        public CategoryRepo(Context context)
        {
            this.db =  context;
        }
        
        public void Delete(int id)
        {
            Category category = db.Categories.Find(id);
            if (category != null)
                db.Categories.Remove(category);
        }

        //public void Save()
        //{
        //    db.SaveChanges();
        //}

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetByID(int id)
        {
            return db.Categories.Find(id);
        }

        public void Create(Category item)
        {
            db.Categories.Add(item);
        }

        public void Update(Category item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public IEnumerable<CategoryRepo> Find(Expression<Func<CategoryRepo, bool>> predicate)
        {
            return db.Set<CategoryRepo>().Where(predicate);
        }
    }
}
