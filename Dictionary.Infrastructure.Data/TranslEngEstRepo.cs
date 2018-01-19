using System;
using System.Collections.Generic;
using System.Text;
using Dictionary.Domain.Core;
using Dictionary.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Dictionary.Infrastructure.Data
{
    public class TranslEngEstRepo: DbContext, IDictionaryRepo<TranslEngEst>,ISearch<TranslEngEst>
    {
        //private DbSet<TranslEngEst> item;
        private Context Context;
        private DbSet<TranslEngEst> DbSet { get; set; }

        public TranslEngEstRepo(Context context)
        {
            this.Context = context;
            this.DbSet = context.Set<TranslEngEst>();
        }

        public void Delete(int id)
        {

            TranslEngEst translengEst = DbSet.Find(id);
            if (translengEst != null)
                DbSet.Remove(translengEst);
        }

        //public void Save()
        //{
        //    db.SaveChanges();
        //}

        //private bool disposed = false;

        //public virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            dbSet.Dispose();
        //        }
        //    }
        //    this.disposed = true;
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

        public IEnumerable<TranslEngEst> GetAll()
        {
            return DbSet.ToList();
        }

        public TranslEngEst GetByID(int id)
        {
            return DbSet.Find(id);
        }

        public void Create(TranslEngEst item)
        {
            DbSet.Add(item);
            
        }

        public void Update(TranslEngEst item)
        {
            DbSet.Attach(item);
            Context.Entry(item).State = EntityState.Modified;
              
        }

        public IEnumerable<TranslEngEst> Find(Expression<Func<TranslEngEst, bool>> predicate)
        {
            yield return DbSet.Find(predicate);
        }
    }
}
