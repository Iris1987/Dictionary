using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.Domain.Core
{
    public abstract class Lang
    {
        

        public int IdWord { get; set; }
        public string Word { get; set; }

        protected Lang() { }
    }
}
