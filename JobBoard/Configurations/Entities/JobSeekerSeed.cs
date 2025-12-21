using JobBoard.Components.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobBoard.Configurations.Entities
{
    public class JobSeekerSeed : IEntityTypeConfiguration<JobSeeker>
    {
        public void Configure(EntityTypeBuilder<JobSeeker> builder)
        {
            builder.HasData(
                new JobSeeker
                {
                    Id = 1,
                    Name = "Alice Johnson",
                    Email = "alice.johnson@example.com",
                    EducationLevel = "Bachelor's in Computer Science",
                    ResumePath = null, 
                    LinkedInPath = "https://www.linkedin.com/in/alicejohnson",
                    Experience = "2 years at TechCorp as Frontend Developer",
                    IdentityUserId = "11111111-2222-3333-4444-555555555555" // Link to JobBoardUser
                },
                new JobSeeker
                {
                    Id = 2,
                    Name = "Bob Smith",
                    Email = "bob.smith@example.com",
                    EducationLevel = "Master's in Data Science",
                    ResumePath = null,
                    LinkedInPath = "https://www.linkedin.com/in/bobsmith",
                    Experience = "3 years at DataSolutions as Data Analyst",
                    IdentityUserId = "22222222-3333-4444-5555-666666666666" // Link to JobBoardUser
                }
            );
        }
    }
}
