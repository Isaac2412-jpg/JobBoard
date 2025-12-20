namespace JobBoard.Components.Domain
{
    public class Employer : BaseDomainModel
    {
        public string CompanyName { get; set; }

        public string CompanyEmail { get; set; }

        public string? CompanyLogoPath { get; set; }

        public  string Industry { get; set; }

        public string Location { get; set; }

        public string WebsiteUrl { get; set; }

        public int UserId { get; set; }
    }   
}
