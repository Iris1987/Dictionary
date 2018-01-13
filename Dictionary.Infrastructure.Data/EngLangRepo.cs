using Dictionary.Domain.Core;
using Dictionary.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Collections.Generic;

using System.Text;
using System.Linq.Expressions;

namespace Dictionary.Infrastructure.Data
{
    public class EngLangRepo: IDictionaryRepo<EngLang>, ISearch<EngLangRepo>
    {

        private Context db;

        public EngLangRepo(Context context)
        {
            this.db = context;
        }

        public void Delete(int id)
        {
            EngLang engLang = db.EngLangs.Find(id);
            if (engLang != null)
                db.EngLangs.Remove(engLang);
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

        public IEnumerable<EngLang> GetAll()
        {
            return db.EngLangs.ToList();
        }

        public EngLang GetByID(int id)
        {
            return db.EngLangs.Find(id);
        }

        public void Create(EngLang item)
        {
            db.EngLangs.Add(item);
        }

        public void Update(EngLang item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public IEnumerable<EngLangRepo> Find(Expression<Func<EngLangRepo, bool>> predicate)
        {
            return db.Set<EngLangRepo>().Where(predicate);
        }
    }
}
