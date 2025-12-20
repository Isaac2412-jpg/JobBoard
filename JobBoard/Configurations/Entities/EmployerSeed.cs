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
                    UserId = 2
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
                    UserId = 2
                }
            );
        }
    }
}
