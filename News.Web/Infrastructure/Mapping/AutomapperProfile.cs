using AutoMapper;
using News.Models;
using News.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace News.Web.Infrastructure.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<Category, CategoryModel>();

            this.CreateMap<Article, ArticleModel>()
                .ForMember(u => u.Category, cfg => cfg.MapFrom(u => u.Category.Name))
                .ForMember(u => u.Author, cfg => cfg.MapFrom(u => u.Author.UserName));
        }
    }
}
