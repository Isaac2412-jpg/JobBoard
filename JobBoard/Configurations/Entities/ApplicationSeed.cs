using JobBoard.Components.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobBoard.Configurations.Entities
{
    public class ApplicationSeed : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.HasData(
                new Application
                {
                    Id = 1,
                    JobListingId = 1,   // Apply to JobListing 1
                    JobSeekerId = 3,    // From JobSeeker 1
                    DateApplied = DateTime.Now.AddDays(-5),
                    Status = "Pending"
                },

                new Application
                {
                    Id = 2,
                    JobListingId = 2,   // Apply to JobListing 2
                    JobSeekerId = 4,    // From JobSeeker 2
                    DateApplied = DateTime.Now.AddDays(-2),
                    Status = "Reviewed"
                }
            );
        }
    }
}
