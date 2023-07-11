using AutoMapper;
using my_website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Application.DTOS.ProjectDTOS
{
    public class ProjectUpdateDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid UserId { get; set; }
    }

    public class ProjectUpdateMappingProfile : Profile
    {
        public ProjectUpdateMappingProfile()
        {
            CreateMap<Project, ProjectUpdateDTO>().ReverseMap();
        }
    }
}
