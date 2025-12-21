namespace JobBoard.Components.Domain
{
    public class Employer : BaseDomainModel
    {
        public string CompanyName { get; set; } = default!;

        public string CompanyEmail { get; set; } = default!;

        public string? CompanyLogoPath { get; set; } 

        public string Industry { get; set; } = default!;

        public string Location { get; set; } = default!;

        public string WebsiteUrl { get; set; } = default!;

        public string IdentityUserId { get; set; } = default!;
        public JobBoard.Data.JobBoardUser User { get; set; } = default!;
    }   
}
