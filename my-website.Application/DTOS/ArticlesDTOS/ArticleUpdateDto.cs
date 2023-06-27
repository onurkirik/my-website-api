using AutoMapper;
using my_website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Application.DTOS.ArticlesDTOS
{
    public class ArticleUpdateDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? UserId { get; set; }
        public Guid CategoryId { get; set; }
    }

    public class ArticleUpdateMappingProfile : Profile
    {
        public ArticleUpdateMappingProfile()
        {
            CreateMap<Article, ArticleUpdateDto>().ReverseMap();
            CreateMap<Article, ArticleCreateDto>().ReverseMap();
        }
    }

}

