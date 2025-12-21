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
                    JobSeekerId = "11111111-2222-3333-4444-555555555555",    // From JobSeeker 1
                    DateApplied = DateTime.Now.AddDays(-5),
                    Status = "Pending"
                },

                new Application
                {
                    Id = 2,
                    JobListingId = 2,   // Apply to JobListing 2
                    JobSeekerId = "22222222-3333-4444-5555-666666666666",    // From JobSeeker 2
                    DateApplied = DateTime.Now.AddDays(-2),
                    Status = "Reviewed"
                }
            );
        }
    }
}
