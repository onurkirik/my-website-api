using AutoMapper;
using my_website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Application.DTOS.CategoriesDTOS
{
    public class CategoryCreateDto
    {
        public string Name { get; set; }
    }
    public class CategoryCreateMappingProfile : Profile
    {
        public CategoryCreateMappingProfile()
        {
            CreateMap<Category, CategoryCreateDto>().ReverseMap();
        }
    }
}
