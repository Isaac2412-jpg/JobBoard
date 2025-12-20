namespace JobBoard.Components.Domain
{
    public class JobSeeker : BaseDomainModel
    {
        public string Name { get; set; }
        
        public string Email { get; set; }

        public string EducationLevel { get; set; }

        public string? ResumePath { get; set; }

        public string? LinkedInPath { get; set; }

        public string? Experience { get; set; }

        public int UserId { get; set; }
    }
}
