using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.BLL.DTO
{
    public class RusEstDTO
    {

        public int ID { get; set; }
        public string RusWord { get; set; }
        public string EstWord { get; set; }
        public string Example { get; set; }

        public string Subcategory { get; set; }
        public string Category { get; set; }
        public string PartOfSpeech { get; set; }

    }
}
