using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.Domain.Core
{
    public class Category
    {

        public Category()
        {
            //TSubcategory = new HashSet<Subcategory>();
        }

        public int IdCategory { get; set; }
        public string Categoryname { get; set; }

        public ICollection<Subcategory> Subcategories { get; set; }

    }
}
