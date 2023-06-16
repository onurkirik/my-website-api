using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using my_website.Domain.Entities;
using my_website.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Persistance.Seeds
{
    public class UserDataSeed : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();

            builder.HasData(
                new AppUser()
                {
                    Id = Guid.Parse("8391C80B-C0F3-478D-A936-C4CF655F20CC"),
                    UserName = "onurkirik",
                    NormalizedUserName = "ONURKIRIK",
                    Name = "Onur",
                    Surname = "KIRIK",
                    Email = "kirikonurr@gmail.com",
                    NormalizedEmail = "KIRIKONURR@GMAIL.COM",
                    EmailConfirmed = true,
                    Age = 23,
                    PhoneNumber = "+905423815262",
                    PersonalInfo = "Lorem ipsum dolor sit amet",
                    Adress = "Altındağ, Ankara",
                    Gender = Gender.Male,
                    BirthDate = new DateTime(1998, 2, 13),
                    PasswordHash = hasher.HashPassword(null!, "Password123")
                });
        }
    }
}
