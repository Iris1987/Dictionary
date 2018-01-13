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
    public class TranslRusEstRepo:IDictionaryRepo<TranslRusEst>,ISearch<TranslRusEstRepo>
    {

        private Context db;

        public TranslRusEstRepo(Context context)
        {
            this.db = context;
        }

        public void Delete(int id)
        {
            TranslRusEst translrusEst = db.TranslRusEsts.Find(id);
            if (translrusEst != null)
                db.TranslRusEsts.Remove(translrusEst);
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

        public IEnumerable<TranslRusEst> GetAll()
        {
            return db.TranslRusEsts.ToList();
        }

        public TranslRusEst GetByID(int id)
        {
            return db.TranslRusEsts.Find(id);
        }

        public void Create(TranslRusEst item)
        {
            db.TranslRusEsts.Add(item);
        }

        public void Update(TranslRusEst item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public IEnumerable<TranslRusEstRepo> Find(Expression<Func<TranslRusEstRepo, bool>> predicate)
        {
            return db.Set<TranslRusEstRepo>().Where(predicate);
        }
    }
}
