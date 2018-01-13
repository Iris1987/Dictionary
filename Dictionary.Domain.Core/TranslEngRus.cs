using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.Domain.Core
{
    public class TranslEngRus:Translation
    {

        //public int IdTranslation { get; set; }
        public int IdWordEng { get; set; }
        public int IdWordRus { get; set; }
        //public int? IdCategory { get; set; }
        //public int? IdPart { get; set; }
        //public string Example { get; set; }

        //public Subcategory Subcategory { get; set; }
        //public PartOfSpeech PartOfSpeech { get; set; }
        public EngLang EngWord { get; set; }
        public RusLang RusWord { get; set; }

        public TranslEngRus() : base() { }
    }
}
