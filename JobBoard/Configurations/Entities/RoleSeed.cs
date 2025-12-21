using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobBoard.Configurations.Entities
{
    public class RoleSeed : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "c3a1f2d4-9b8e-4a21-a1b2-01f0e5d6c789",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },

                new IdentityRole
                {
                    Id = "d7e4c1b2-8a9f-4c33-b1a0-92e4f6d8c123",
                    Name = "Employer",
                    NormalizedName = "EMPLOYER"
                },

                new IdentityRole
                {
                    Id = "e9b7a3d2-5f61-4c9b-8a11-0b3f8c4e5678",
                    Name = "JobSeeker",
                    NormalizedName = "JOBSEEKER"
                }
             );
        }
    }
}
