using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.Domain.Core
{
    public class EstLang: Lang
    {

        public EstLang():base()
        {
            //TTranslationEngEst = new HashSet<TTranslationEngEst>();
            //TTranslationRusEst = new HashSet<TTranslationRusEst>();
        }

        //public int IdWord { get; set; }
        //public string Word { get; set; }

        public ICollection<TranslEngEst> TranslEngEsts { get; set; }
        public ICollection<TranslRusEst> TranslRusEst { get; set; }

    }
}
