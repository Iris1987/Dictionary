using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.BLL.DTO
{
    public class EngRusDTO
    {

        public int ID { get; set; }
        public string EngWord { get; set; }
        public string RusWord { get; set; }
        public string Example { get; set; }

        public string Subcategory { get; set; }
        public string Category { get; set; }
        public string PartOfSpeech { get; set; }

    }
}
