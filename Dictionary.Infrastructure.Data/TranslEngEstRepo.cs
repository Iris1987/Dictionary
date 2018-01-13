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
    public class TranslEngEstRepo:IDictionaryRepo<TranslEngEst>,ISearch<TranslEngEst>
    {

        private Context db;

        public TranslEngEstRepo(Context context)
        {
            this.db = context;
        }

        public void Delete(int id)
        {
            TranslEngEst translengEst = db.TranslEngEsts.Find(id);
            if (translengEst != null)
                db.TranslEngEsts.Remove(translengEst);
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

        public IEnumerable<TranslEngEst> GetAll()
        {
            return db.TranslEngEsts.ToList();
        }

        public TranslEngEst GetByID(int id)
        {
            return db.TranslEngEsts.Find(id);
        }

        public void Create(TranslEngEst item)
        {
            db.TranslEngEsts.Add(item);
        }

        public void Update(TranslEngEst item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public IEnumerable<TranslEngEst> Find(Expression<Func<TranslEngEst, bool>> predicate)
        {
            return db.Set<TranslEngEst>().Where(predicate);
        }
    }
}
