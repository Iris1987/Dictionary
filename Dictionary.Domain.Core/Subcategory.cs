using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.Domain.Core
{
    public class Subcategory
    {

        public Subcategory()
        {
            //TTranslationEngEst = new HashSet<TTranslationEngEst>();
            //TTranslationEngRus = new HashSet<TTranslationEngRus>();
            //TTranslationRusEst = new HashSet<TTranslationRusEst>();
        }

        public int IdSubcategory { get; set; }
        public string Subcategoryname { get; set; }
        public Category Category { get; set; }
        public int categoryID { get; set; }

        public ICollection<TranslEngEst> TranslEngEst { get; set; }
        public ICollection<TranslEngRus> TranslEngRus { get; set; }
        public ICollection<TranslRusEst> TranslRusEst { get; set; }


    }
}
