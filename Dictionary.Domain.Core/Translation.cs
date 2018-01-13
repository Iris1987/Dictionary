using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.Domain.Core
{
     public abstract class Translation
    {

        public int IdTranslation { get; set; }
        
        public int? IdCategory { get; set; }
        public int? IdPart { get; set; }
        public string Example { get; set; }

        public Subcategory Subcategory { get; set; }
        public PartOfSpeech PartOfSpeech { get; set; }

        protected Translation() { }
    }
}
