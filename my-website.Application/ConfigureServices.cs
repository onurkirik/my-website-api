using Microsoft.Extensions.DependencyInjection;
using my_website.Application.Repositories.ArticleRepository;
using my_website.Application.Repositories.CategoryRepository;
using my_website.Application.Repositories.CertificateRepository;
using my_website.Application.Repositories.EducationRepository;
using my_website.Application.Repositories;
using my_website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using my_website.Application.DTOS.ArticlesDTOS;
using my_website.Application.DTOS.CategoriesDTOS;
using my_website.Application.DTOS.ProjectDTOS;
using my_website.Application.DTOS.EducationDTOS;
using my_website.Application.DTOS.SkillsDTOS;
using my_website.Application.DTOS.CertificateDTOS;
using my_website.Application.DTOS.SocialMediaDTOS;
using my_website.Application.DTOS.WorkExperienceDTOS;

namespace my_website.Application
{
    public static class ConfigureServices
    {
        public static void ConfigureApplicationService(this IServiceCollection services)
        {
            // Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ArticleUpdateMappingProfile());
                mc.AddProfile(new CategoryCreateMappingProfile());
                mc.AddProfile(new CategoryUpdateMappingProfile());
                mc.AddProfile(new ProjectCreateMappingProfile());
                mc.AddProfile(new ProjectUpdateMappingProfile());
                mc.AddProfile(new EducationCreateMappingProfile());
                mc.AddProfile(new EducationUpdateMappingProfile());
                mc.AddProfile(new SkillsCreateMappingProfile());
                mc.AddProfile(new SkillsUpdateMappingProfile());
                mc.AddProfile(new CertificateCreateMappingProfile());
                mc.AddProfile(new CertificateUpdateMappingProfile());
                mc.AddProfile(new SocialMediaCreateMappingProfile());
                mc.AddProfile(new SocialMediaUpdateMappingProfile());
                mc.AddProfile(new WorkExperienceCreateMappingProfile());
                mc.AddProfile(new WorkExperienceUpdateMappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

        }
    }
}
