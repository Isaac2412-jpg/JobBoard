using JobBoard.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JobBoard.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<JobBoardUser>
    {
        public void Configure(EntityTypeBuilder<JobBoardUser> builder)
        {
            var hasher = new PasswordHasher<JobBoardUser>();
            builder.HasData(
            new JobBoardUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            }
            );
        }
    }
}
