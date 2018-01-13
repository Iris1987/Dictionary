using System;
using System.Collections.Generic;
using System.Text;
using Dictionary.Domain.Core;


namespace Dictionary.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {

        IDictionaryRepo<Category> Categories { get; }
        IDictionaryRepo<Subcategory> Subcategories { get; }
        IDictionaryRepo<PartOfSpeech> PartsOfSpeech { get; }
            IDictionaryRepo<EngLang> EngLangs { get; }
            IDictionaryRepo<RusLang> RusLangs { get; }
            IDictionaryRepo<EstLang> EstLangs { get; }
            IDictionaryRepo<TranslEngEst> TranslEngEsts { get; }
            IDictionaryRepo<TranslEngRus> TranslEngRuses { get; }
            IDictionaryRepo<TranslRusEst> TranslRusEsts { get; }
        void Save();
        //void Update();

    }
}
