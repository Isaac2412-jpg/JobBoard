using JobBoard.Components.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobBoard.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    UserName = "AdminUser",
                    Email = "admin@example.com",
                    Role = "Admin",
                    AccountType = "Admin"
                },

                new User
                {
                    Id = 2,
                    UserName = "EmployerUser",
                    Email = "employer@example.com",
                    Role = "Employer",
                    AccountType = "Standard"
                },

                new User
                {
                    Id = 3,
                    UserName = "JobSeekerUser",
                    Email = "jobseeker@example.com",
                    Role = "JobSeeker",
                    AccountType = "Standard"
                }
            );
        }
    }
}
