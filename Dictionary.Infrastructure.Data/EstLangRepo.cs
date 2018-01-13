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
    public class EstLangRepo:IDictionaryRepo<EstLang>, ISearch<EstLangRepo>
    {

        private Context db;

        public EstLangRepo(Context context)
        {
            this.db = context;
        }

        public void Delete(int id)
        {
            EstLang estLang = db.EstLangs.Find(id);
            if (estLang != null)
                db.EstLangs.Remove(estLang);
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

        public IEnumerable<EstLang> GetAll()
        {
            return db.EstLangs.ToList();
        }

        public EstLang GetByID(int id)
        {
            return db.EstLangs.Find(id);
        }

        public void Create(EstLang item)
        {
            db.EstLangs.Add(item);
        }

        public void Update(EstLang item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public IEnumerable<EstLangRepo> Find(Expression<Func<EstLangRepo, bool>> predicate)
        {
            
                return db.Set<EstLangRepo>().Where(predicate);
        }
    }
}
