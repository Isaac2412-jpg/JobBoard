namespace JobBoard.Components.Domain
{
    public class JobSeeker : BaseDomainModel
    {
        public string Name { get; set; } = default!;
        
        public string Email { get; set; } = default!;

        public string EducationLevel { get; set; } = default!;

        public string? ResumePath { get; set; }

        public string? LinkedInPath { get; set; }

        public string? Experience { get; set; }

        public string IdentityUserId { get; set; } = default!;
        public JobBoard.Data.JobBoardUser User { get; set; } = default!;
    }
}
