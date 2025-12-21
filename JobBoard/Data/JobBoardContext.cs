using JobBoard.Configurations.Entities;
using JobBoard.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JobBoard.Data
{
    public class JobBoardContext(DbContextOptions<JobBoardContext> options) : IdentityDbContext<JobBoardUser>(options)
    {
        public DbSet<JobBoard.Components.Domain.JobListing> JobListing { get; set; } = default!;
        public DbSet<JobBoard.Components.Domain.Employer> Employer { get; set; } = default!;
        public DbSet<JobBoard.Components.Domain.FeedBack> FeedBack { get; set; } = default!;
        public DbSet<JobBoard.Components.Domain.JobSeeker> JobSeeker { get; set; } = default!;
        public DbSet<JobBoard.Components.Domain.Application> Application { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ApplicationSeed());
            builder.ApplyConfiguration(new EmployerSeed());
            builder.ApplyConfiguration(new FeedBackSeed());
            builder.ApplyConfiguration(new JobListingSeed());
            builder.ApplyConfiguration(new JobSeekerSeed());
            builder.ApplyConfiguration(new UserSeed());

        }

    }
}
