using AutoMapper;
using my_website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Application.DTOS.SkillsDTOS
{
    public class SkillsUpdateDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public Guid UserId { get; set; }
    }

    public class SkillsUpdateMappingProfile : Profile
    {
        public SkillsUpdateMappingProfile()
        {
            CreateMap<Skills, SkillsUpdateDTO>().ReverseMap();
        }
    }
}
