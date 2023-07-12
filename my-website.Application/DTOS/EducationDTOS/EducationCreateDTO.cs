using AutoMapper;
using my_website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Application.DTOS.EducationDTOS
{
    public class EducationCreateDTO
    {
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid UserId { get; set; }
    }

    public class EducationCreateMappingProfile : Profile
    {
        public EducationCreateMappingProfile()
        {
            CreateMap<Education, EducationCreateDTO>().ReverseMap();
        }
    }
}
