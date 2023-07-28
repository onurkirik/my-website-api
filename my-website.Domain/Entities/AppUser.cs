using Microsoft.AspNetCore.Identity;
using my_website.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Domain.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string PersonalInfo { get; set; }
        public string Adress { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string? ImageUrl { get; set; }

        //Navigation Property
        public Guid? ArticleId { get; set; }
        public Article? Article { get; set; }
        public ICollection<SocialMedia> SocialMedias { get; set; }
        public ICollection<Certificate> Certificates { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Skills> Skills { get; set; }
        public ICollection<WorkExperience> Experiences { get; set; }
        public ICollection<Education> Educations { get; set; }
    }
}
