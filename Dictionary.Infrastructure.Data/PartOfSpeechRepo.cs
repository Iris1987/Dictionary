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
    public class PartOfSpeechRepo:IDictionaryRepo<PartOfSpeech>, ISearch<PartOfSpeechRepo>
    {
        private Context db;

        public PartOfSpeechRepo(Context context)
        {
            this.db = context;
        }

        public void Delete(int id)
        {
            PartOfSpeech partofSpeech = db.PartsOfSpeech.Find(id);
            if (partofSpeech != null)
                db.PartsOfSpeech.Remove(partofSpeech);
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

        public IEnumerable<PartOfSpeech> GetAll()
        {
            return db.PartsOfSpeech.ToList();
        }

        public PartOfSpeech GetByID(int id)
        {
            return db.PartsOfSpeech.Find(id);
        }

        public void Create(PartOfSpeech item)
        {
            db.PartsOfSpeech.Add(item);
        }

        public void Update(PartOfSpeech item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public IEnumerable<PartOfSpeechRepo> Find(Expression<Func<PartOfSpeechRepo, bool>> predicate)
        {
            return db.Set<PartOfSpeechRepo>().Where(predicate);
        }
    }
}
