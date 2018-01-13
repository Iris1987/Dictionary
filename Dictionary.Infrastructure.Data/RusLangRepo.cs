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
    public class RusLangRepo:IDictionaryRepo<RusLang>,ISearch<RusLangRepo>
    {

        private Context db;

        public RusLangRepo(Context context)
        {
            this.db = context;
        }

        public void Delete(int id)
        {
            RusLang rusLang = db.RusLangs.Find(id);
            if (rusLang != null)
                db.RusLangs.Remove(rusLang);
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

        public IEnumerable<RusLang> GetAll()
        {
            return db.RusLangs.ToList();
        }

        public RusLang GetByID(int id)
        {
            return db.RusLangs.Find(id);
        }

        public void Create(RusLang item)
        {
            db.RusLangs.Add(item);
        }

        public void Update(RusLang item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public IEnumerable<RusLangRepo> Find(Expression<Func<RusLangRepo, bool>> predicate)
        {
            return db.Set<RusLangRepo>().Where(predicate);
        }
    }
}
