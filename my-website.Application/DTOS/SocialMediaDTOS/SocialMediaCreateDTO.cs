using AutoMapper;
using my_website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Application.DTOS.SocialMediaDTOS
{
    public class SocialMediaCreateDTO
    {
        public string Link { get; set; }
        public Guid UserId { get; set; }
    }

    public class SocialMediaCreateMappingProfile : Profile
    {
        public SocialMediaCreateMappingProfile()
        {
            CreateMap<SocialMedia, SocialMediaCreateDTO>().ReverseMap();
        }
    }
}
