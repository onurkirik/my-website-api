using AutoMapper;
using my_website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Application.DTOS.SocialMediaDTOS
{
    public class SocialMediaUpdateDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public Guid UserId { get; set; }
    }

    public class SocialMediaUpdateMappingProfile : Profile
    {
        public SocialMediaUpdateMappingProfile()
        {
            CreateMap<SocialMedia, SocialMediaUpdateDTO>().ReverseMap();
        }
    }
}
