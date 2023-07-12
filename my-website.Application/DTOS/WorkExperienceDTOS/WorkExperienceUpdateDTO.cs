using AutoMapper;
using my_website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Application.DTOS.WorkExperienceDTOS
{
    public class WorkExperienceUpdateDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Content { get; set; }
        public Guid UserId { get; set; }
    }

    public class WorkExperienceUpdateMappingProfile : Profile
    {
        public WorkExperienceUpdateMappingProfile()
        {
            CreateMap<WorkExperience, WorkExperienceUpdateDTO>().ReverseMap();
        }
    }
}
