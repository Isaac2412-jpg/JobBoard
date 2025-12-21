using JobBoard.Components.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobBoard.Configurations.Entities
{
    public class EmployerSeed : IEntityTypeConfiguration<Employer>
    {
        public void Configure(EntityTypeBuilder<Employer> builder)
        {
            builder.HasData(
                new Employer
                {
                    Id = 1,
                    CompanyName = "TechCorp",
                    CompanyEmail = "contact@techcorp.com",
                    CompanyLogoPath = null,
                    Industry = "Software",
                    Location = "New York, NY",
                    WebsiteUrl = "https://techcorp.com",
                    IdentityUserId = "22222222-3333-4444-5555-666666666666"
                },

                new Employer
                {
                    Id = 2,
                    CompanyName = "HealthPlus",
                    CompanyEmail = "info@healthplus.com",
                    CompanyLogoPath = null,
                    Industry = "Healthcare",
                    Location = "Boston, MA",
                    WebsiteUrl = "https://healthplus.com",
                    IdentityUserId = "33333333-4444-5555-6666-777777777777"
                }
            );
        }
    }
}
