using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.Domain.Core
{
    public class TranslRusEst:Translation
    {

        //public int IdTranslation { get; set; }
        public int IdWordRus { get; set; }
        public int IdWordEst { get; set; }
        //public int? IdCategory { get; set; }
        //public int? IdPart { get; set; }
        //public string Example { get; set; }

        //public Subcategory Subcategory { get; set; }
        //public PartOfSpeech PartOfSpeech { get; set; }
        public RusLang RusWord { get; set; }
        public EstLang EstWord { get; set; }

        public TranslRusEst() : base() { }
    }
}
