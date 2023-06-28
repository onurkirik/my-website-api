using AutoMapper;
using my_website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Application.DTOS.CategoriesDTOS
{
    public class CategoryUpdateDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class CategoryUpdateMappingProfile : Profile
    {
        public CategoryUpdateMappingProfile()
        {
            CreateMap<Category, CategoryUpdateDto>().ReverseMap();
        }
    }
}
