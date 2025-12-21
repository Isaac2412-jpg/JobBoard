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
                    Id = "11111111-2222-3333-4444-555555555555", // JobSeeker 1
                    Email = "alice.johnson@example.com",
                    UserName = "alice.johnson@example.com",
                    NormalizedEmail = "ALICE.JOHNSON@EXAMPLE.COM",
                    NormalizedUserName = "ALICE.JOHNSON@EXAMPLE.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },

                new JobBoardUser
                {
                    Id = "22222222-3333-4444-5555-666666666666", // JobSeeker 2
                    Email = "bob.smith@example.com",
                    UserName = "bob.smith@example.com",
                    NormalizedEmail = "BOB.SMITH@EXAMPLE.COM",
                    NormalizedUserName = "BOB.SMITH@EXAMPLE.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },

                new JobBoardUser
                {
                    Id = "33333333-4444-5555-6666-777777777777", // Employer 1
                    Email = "employer1@techcorp.com",
                    UserName = "employer1@techcorp.com",
                    NormalizedEmail = "EMPLOYER1@TECHCORP.COM",
                    NormalizedUserName = "EMPLOYER1@TECHCORP.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },

                new JobBoardUser 
                {
                    Id = "44444444-5555-6666-7777-888888888888", // Employer 2
                    Email = "employer2@healthplus.com",
                    UserName = "employer2@healthplus.com",
                    NormalizedEmail = "EMPLOYER2@HEALTHPLUS.COM",
                    NormalizedUserName = "EMPLOYER2@HEALTHPLUS.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },

                new JobBoardUser
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4", // Admin
                    Email = "admin@localhost.com",
                    UserName = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                }
            );
        }
    }
}
