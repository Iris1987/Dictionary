using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.Domain.Core
{
    public class EngLang: Lang
    {

        public EngLang():base()
        {
            //TTranslationEngEst = new HashSet<TTranslationEngEst>();
            //TTranslationEngRus = new HashSet<TTranslationEngRus>();
        }

        //public int IdWord { get; set; }
        //public string Word { get; set; }

        public ICollection<TranslEngEst> TranslEngEsts { get; set; }
        public ICollection<TranslEngRus> TranslEngRuses { get; set; }

    }
}
