using AutoMapper;
using my_website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Application.DTOS.WorkExperienceDTOS
{
    public class WorkExperienceCreateDTO
    {
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Content { get; set; }
        public Guid UserId { get; set; }
    }

    public class WorkExperienceCreateMappingProfile : Profile
    {
        public WorkExperienceCreateMappingProfile()
        {
            CreateMap<WorkExperience, WorkExperienceCreateDTO>().ReverseMap();
        }
    }
}
