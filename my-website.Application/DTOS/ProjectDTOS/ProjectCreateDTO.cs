﻿using AutoMapper;
using my_website.Application.DTOS.ArticlesDTOS;
using my_website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Application.DTOS.ProjectDTOS
{
    public class ProjectCreateDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid UserId { get; set; }
    }

    public class ProjectCreateMappingProfile : Profile
    {
        public ProjectCreateMappingProfile()
        {
            CreateMap<Project, ProjectCreateDTO>().ReverseMap();
        }
    }
}
