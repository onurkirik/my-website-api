using AutoMapper;
using my_website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Application.DTOS.SkillsDTOS
{
    public class SkillsCreateDTO
    {
        public string Name { get; set; }
        public int Rate { get; set; }
        public Guid UserId { get; set; }
    }

    public class SkillsCreateMappingProfile : Profile
    {
        public SkillsCreateMappingProfile()
        {
            CreateMap<Skills, SkillsCreateDTO>().ReverseMap();
        }
    }
}
