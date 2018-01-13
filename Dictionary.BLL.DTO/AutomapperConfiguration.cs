using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

using Dictionary.Domain.Core;

namespace Dictionary.BLL.DTO
{
    public static class AutomapperConfiguration
    {

        public static void Configure()
        {
            var configEngEst = new MapperConfiguration(cfg => cfg.CreateMap<TranslEngEst, EngEstDTO>()
            .ForMember(des=>des.ID, x=>x.MapFrom(src=>src.IdTranslation))
            .ForMember(des=>des.PartOfSpeech, x=>x.MapFrom(src=>src.PartOfSpeech.Partname))
            .ForMember(des=>des.Subcategory,x=>x.MapFrom(src=>src.Subcategory.Subcategoryname))
            .ForMember(des=>des.Category,x=>x.MapFrom(src=>src.Subcategory.Category.Categoryname))
            .ForMember(des=>des.EngWord,x=>x.MapFrom(src=>src.EngWord.Word))
            .ForMember(des=>des.EstWord,x=>x.MapFrom(src=>src.EstWord.Word)));

            //hz
            var configEngEstViseVersa = new MapperConfiguration(cfg => cfg.CreateMap<EngEstDTO, TranslEngEst>()
            .ForMember(des => des.IdTranslation, x => x.MapFrom(src => src.ID))
            .ForMember(des => des.PartOfSpeech.Partname, x => x.MapFrom(src => src.PartOfSpeech))
            .ForMember(des => des.Subcategory.Subcategoryname, x => x.MapFrom(src => src.Subcategory))
            .ForMember(des => des.Subcategory.Category.Categoryname, x => x.MapFrom(src => src.Category))
            .ForMember(des => des.EngWord.Word, x => x.MapFrom(src => src.EngWord))
            .ForMember(des => des.EstWord.Word, x => x.MapFrom(src => src.EstWord)));


            var configEngRus = new MapperConfiguration(cfg => cfg.CreateMap<TranslEngRus, EngRusDTO>()
            .ForMember(des => des.ID, x => x.MapFrom(src => src.IdTranslation))
            .ForMember(des => des.PartOfSpeech, x => x.MapFrom(src => src.PartOfSpeech.Partname))
            .ForMember(des => des.Subcategory, x => x.MapFrom(src => src.Subcategory.Subcategoryname))
            .ForMember(des => des.Category, x => x.MapFrom(src => src.Subcategory.Category.Categoryname))
            .ForMember(des => des.EngWord, x => x.MapFrom(src => src.EngWord.Word))
            .ForMember(des => des.RusWord, x => x.MapFrom(src => src.RusWord.Word)));
            var configRusEst = new MapperConfiguration(cfg => cfg.CreateMap<TranslRusEst, RusEstDTO>().ForMember(des => des.ID, x => x.MapFrom(src => src.IdTranslation))
            .ForMember(des => des.PartOfSpeech, x => x.MapFrom(src => src.PartOfSpeech.Partname))
            .ForMember(des => des.Subcategory, x => x.MapFrom(src => src.Subcategory.Subcategoryname))
            .ForMember(des => des.Category, x => x.MapFrom(src => src.Subcategory.Category.Categoryname))
            .ForMember(des => des.RusWord, x => x.MapFrom(src => src.RusWord.Word))
            .ForMember(des => des.EstWord, x => x.MapFrom(src => src.EstWord.Word)));

            //.ForMember(dest => dest.Author,
            //           opts => opts.MapFrom(src => src.Author.Name));
        }

        public static void Example()
        {
            

        }

    
    }
}
