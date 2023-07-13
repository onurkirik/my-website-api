using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using my_website.Application.Repositories;
using my_website.Application.Repositories.ArticleRepository;
using my_website.Application.Repositories.CategoryRepository;
using my_website.Application.Repositories.CertificateRepository;
using my_website.Application.Repositories.EducationRepository;
using my_website.Application.Repositories.ProjectRepository;
using my_website.Application.Repositories.SkillsRepository;
using my_website.Application.Repositories.SocialMediaRepository;
using my_website.Application.Repositories.WorkExperienceRepository;
using my_website.Domain.Entities;
using my_website.Persistance.Context;
using my_website.Persistance.Repositories;
using my_website.Persistance.Repositories.ArticleRepository;
using my_website.Persistance.Repositories.CategoryRepository;
using my_website.Persistance.Repositories.CertificateRepository;
using my_website.Persistance.Repositories.EducationRepository;
using my_website.Persistance.Repositories.ProjectRepository;
using my_website.Persistance.Repositories.SkillsRepository;
using my_website.Persistance.Repositories.SocialMediaRepository;
using my_website.Persistance.Repositories.WorkExperienceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Persistance
{
    public static class DateAccessExtension
    {
        public static void AddPersistance(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(o => o.UseSqlServer(connectionString));
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddScoped<IArticleReadRepository, ArticleReadRepository>();
            services.AddScoped<IArticleWriteRepository, ArticleWriteRepository>();
            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
            services.AddScoped<ICertificateReadRepository, CertificateReadRepository>();
            services.AddScoped<ICertificateWriteRepository, CertificateWriteRepository>();
            services.AddScoped<IEducationReadRepository, EducationReadRepository>();
            services.AddScoped<IEducationWriteRepository, EducationWriteRepository>();
            services.AddScoped<IProjectReadRepository, ProjectReadRepository>();
            services.AddScoped<IProjectWriteRepository, ProjectWriteRepository>();
            services.AddScoped<IWorkExperienceReadRepository, WorkExperienceReadRepository>();
            services.AddScoped<IWorkExperienceWriteRepository, WorkExperienceWriteRepository>();
            services.AddScoped<ISkillReadRepository, SkillsReadRepository>();
            services.AddScoped<ISkillWriteRepository, SkillsWriteRepository>();
            services.AddScoped<ISocialMediaReadRepository, SocialMediaReadRepository>();
            services.AddScoped<ISocialMediaWriteRepository, SocialMediaWriteRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }
    }
}
