using Dictionary.Domain.Core;
using Dictionary.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Dictionary.Infrastructure.Data
{
    public class SubcategoryRepo: IDictionaryRepo<Subcategory>,ISearch<SubcategoryRepo>
    {
        private Context db;

        public SubcategoryRepo(Context context)
        {
            this.db = context;
        }

        public void Delete(int id)
        {
            Subcategory subCategory = db.Subcategories.Find(id);
            if (subCategory != null)
                db.Subcategories.Remove(subCategory);
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

        public IEnumerable<Subcategory> GetAll()
        {
            return db.Subcategories.ToList();
        }

        public Subcategory GetByID(int id)
        {
            return db.Subcategories.Find(id);
        }

        public void Create(Subcategory item)
        {
            db.Subcategories.Add(item);
        }

        public void Update(Subcategory item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public IEnumerable<SubcategoryRepo> Find(Expression<Func<SubcategoryRepo, bool>> predicate)
        {
            return db.Set<SubcategoryRepo>().Where(predicate);
        }
    }
}
