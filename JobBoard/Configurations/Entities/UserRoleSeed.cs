using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobBoard.Configurations.Entities
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
    // Admin
    new IdentityUserRole<string>
    {
        UserId = "3781efa7-66dc-47f0-860f-e506d04102e4",
        RoleId = "c3a1f2d4-9b8e-4a21-a1b2-01f0e5d6c789"
    },

    // Employer 1
    new IdentityUserRole<string>
    {
        UserId = "33333333-4444-5555-6666-777777777777",
        RoleId = "d7e4c1b2-8a9f-4c33-b1a0-92e4f6d8c123"
    },

    // Employer 2
    new IdentityUserRole<string>
    {
        UserId = "44444444-5555-6666-7777-888888888888",
        RoleId = "d7e4c1b2-8a9f-4c33-b1a0-92e4f6d8c123"
    },

    // JobSeeker 1
    new IdentityUserRole<string>
    {
        UserId = "11111111-2222-3333-4444-555555555555",
        RoleId = "e9b7a3d2-5f61-4c9b-8a11-0b3f8c4e5678"
    },

    // JobSeeker 2
    new IdentityUserRole<string>
    {
        UserId = "22222222-3333-4444-5555-666666666666",
        RoleId = "e9b7a3d2-5f61-4c9b-8a11-0b3f8c4e5678"
    }
);

        }
    }
}
