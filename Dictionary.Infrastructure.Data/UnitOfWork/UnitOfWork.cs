using Dictionary.Domain.Core;
using Dictionary.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.Infrastructure.Data.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {

        private Context db; //= new Context();
        private CategoryRepo cat;
        private SubcategoryRepo sub;
        private EngLangRepo eng;
        private RusLangRepo rus;
        private EstLangRepo est;
        private TranslEngEstRepo engest;
        private TranslEngRusRepo engrus;
        private TranslRusEstRepo rusest;
        private PartOfSpeechRepo part;


        public UnitOfWork(string connectionstring)
        {

            db = new Context(connectionstring);

        }

        
        public IDictionaryRepo<Subcategory> Subcategories
        {
            get
            {
                if (sub == null)
                {
                    sub = new SubcategoryRepo(db);
                }
                return sub;
            }
        }

        public IDictionaryRepo<PartOfSpeech> PartsOfSpeech
        {
            get
            {
                if (part == null)
                {
                    part = new PartOfSpeechRepo(db);
                }
                return part;
            }
        }

        public IDictionaryRepo<EngLang> EngLangs
        {
            get
            {
                if (eng == null)
                {
                    eng = new EngLangRepo(db);
                }
                return eng;
            }
        }

        public IDictionaryRepo<RusLang> RusLangs
        {
            get
            {
                if (rus == null)
                {
                    rus = new RusLangRepo(db);
                }
                return rus;
            }
        }

        public IDictionaryRepo<EstLang> EstLangs
        {
            get
            {
                if (est == null)
                {
                    est = new EstLangRepo(db);
                }
                return est;
            }
        }

        public IDictionaryRepo<TranslEngEst> TranslEngEsts
        {
            get
            {
                if (engest == null)
                {
                    engest = new TranslEngEstRepo(db);
                }
                return engest;
            }
        }
        public IDictionaryRepo<TranslEngRus> TranslEngRuses
        {
            get
            {
                if (engrus == null)
                {
                    engrus = new TranslEngRusRepo(db);
                }
                return engrus;
            }
        }

        public IDictionaryRepo<TranslRusEst> TranslRusEsts
        {
            get
            {
                if (rusest == null)
                {
                    rusest = new TranslRusEstRepo(db);
                }
                return rusest;
            }
        }

        public IDictionaryRepo<Category> Categories
        {
            get
            {
                if (cat == null)
                {
                    cat = new CategoryRepo(db);
                }
                return cat;
            }
        }


        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
