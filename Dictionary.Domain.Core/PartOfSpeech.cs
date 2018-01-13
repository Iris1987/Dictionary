using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.Domain.Core
{
    public class PartOfSpeech
    {

        public PartOfSpeech()
        {
            //    TTranslationEngEst = new HashSet<TTranslationEngEst>();
            //    TTranslationEngRus = new HashSet<TTranslationEngRus>();
            //    TTranslationRusEst = new HashSet<TTranslationRusEst>();
        }

    public int IdPart { get; set; }
        public string Partname { get; set; }

        public ICollection<TranslEngEst> TranslEngEst { get; set; }
        public ICollection<TranslEngRus> TranslEngRus { get; set; }
        public ICollection<TranslRusEst> TranslRusEst { get; set; }

    }
}
