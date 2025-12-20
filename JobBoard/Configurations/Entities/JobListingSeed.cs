using JobBoard.Components.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobBoard.Configurations.Entities
{
    public class JobListingSeed : IEntityTypeConfiguration<JobListing>
    {
        public void Configure(EntityTypeBuilder<JobListing> builder)
        {
            builder.HasData(
                new JobListing
                {
                    Id = 1,
                    Title = "Frontend Developer",
                    JobType = "Full-time",
                    Industry = "Software",
                    Salary = 80000,
                    Location = "New York, NY",
                    Description = "Develop and maintain web applications using modern frameworks.",
                    Requirements = "Proficient in C#, ASP.NET, and React.",
                    DatePosted = DateTime.Now,
                    EmployerId = 1
                },

                new JobListing
                {
                    Id = 2,
                    Title = "Backend Developer",
                    JobType = "Full-time",
                    Industry = "Software",
                    Salary = 85000,
                    Location = "San Francisco, CA",
                    Description = "Work on APIs and server-side logic.",
                    Requirements = "Experience with C#, .NET Core, SQL Server.",
                    DatePosted = DateTime.Now,
                    EmployerId = 1
                },

                new JobListing
                {
                    Id = 3,
                    Title = "Data Analyst",
                    JobType = "Part-time",
                    Industry = "Finance",
                    Salary = 60000,
                    Location = "Chicago, IL",
                    Description = "Analyze data to provide actionable insights.",
                    Requirements = "SQL, Excel, and Power BI experience.",
                    DatePosted = DateTime.Now,
                    EmployerId = 2
                }
            );
        }
    }
}
