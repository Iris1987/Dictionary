using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
//using Dictionary.Domain.Core;

namespace Dictionary.BLL.DTO
{
    public class EngEstDTO
    {
        public int ID { get; set; }
        public string EngWord { get; set; }
        public string EstWord { get; set; }
        public string Example { get; set; }

        public string Subcategory { get; set; }
        public string Category  { get; set; }
        public string PartOfSpeech { get; set; }

        public EngEstDTO()
        { }
        //public EngEstDTO(TranslEngEst domainObject)
        //{
        //    this.prop = domainObject.getProp();
        //}
    }
}
