using JobBoard.Configurations.Entities;
using JobBoard.Components.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JobBoard.Data
{
    public class JobBoardContext : IdentityDbContext<JobBoardUser>
    {
        public JobBoardContext(DbContextOptions<JobBoardContext> options)
            : base(options)
        {
        }

        public DbSet<JobListing> JobListing { get; set; } = default!;
        public DbSet<Employer> Employer { get; set; } = default!;
        public DbSet<FeedBack> FeedBack { get; set; } = default!;
        public DbSet<JobSeeker> JobSeeker { get; set; } = default!;
        public DbSet<Application> Application { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ApplicationSeed());
            builder.ApplyConfiguration(new EmployerSeed());
            builder.ApplyConfiguration(new FeedBackSeed());
            builder.ApplyConfiguration(new JobListingSeed());
            builder.ApplyConfiguration(new JobSeekerSeed());

            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
        }
    }
}

