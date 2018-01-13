using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.Domain.Core
{
    public class RusLang: Lang
    {

        public RusLang():base()
        {
            //TTranslationEngRus = new HashSet<TTranslationEngRus>();
            //TTranslationRusEst = new HashSet<TTranslationRusEst>();
        }

        //public int IdWord { get; set; }
        //public string Word { get; set; }

        public ICollection<TranslEngRus> TranslEngRuses { get; set; }
        public ICollection<TranslRusEst> TranslRusEsts { get; set; }

        
    }
}
