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
                new IdentityUserRole<string>
                {
                    UserId = "3781efa7-66dc-47f0-860f-e506d04102e4", //admin 
                    RoleId = "c3a1f2d4-9b8e-4a21-a1b2-01f0e5d6c789"
                }
            );
        }
    }
}
