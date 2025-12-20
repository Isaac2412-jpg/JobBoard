using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JobBoard.Components.Domain;
using JobBoard.Configurations.Entities;

namespace JobBoard.Data
{
    public class JobBoardContext : DbContext
    {
        public JobBoardContext (DbContextOptions<JobBoardContext> options)
            : base(options)
        {
        }

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
