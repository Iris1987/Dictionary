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
    public class TranslEngRusRepo:IDictionaryRepo<TranslEngRus>, ISearch<TranslEngRusRepo>
    {

        private Context db;

        public TranslEngRusRepo(Context context)
        {
            this.db = context;
        }

        public void Delete(int id)
        {
            TranslEngRus translengRus = db.TranslEngRuses.Find(id);
            if (translengRus != null)
                db.TranslEngRuses.Remove(translengRus);
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

        public IEnumerable<TranslEngRus> GetAll()
        {
            return db.TranslEngRuses.ToList();
        }

        public TranslEngRus GetByID(int id)
        {
            return db.TranslEngRuses.Find(id);
        }

        public void Create(TranslEngRus item)
        {
            db.TranslEngRuses.Add(item);
        }

        public void Update(TranslEngRus item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public IEnumerable<TranslEngRusRepo> Find(Expression<Func<TranslEngRusRepo, bool>> predicate)
        {
            return db.Set<TranslEngRusRepo>().Where(predicate);
        }
    }
}
