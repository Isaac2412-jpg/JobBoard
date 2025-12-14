namespace JobBoard.Components.Domain
{
    public class Employer
    {
        public  required string CompanyName { get; set; }

        public required string CompanyEmail { get; set; }

        public string? CompanyLogoPath { get; set; }

        public required string Industry { get; set; }

        public required string Location { get; set; }

        public required string WebsiteUrl { get; set; }

        public int UserId { get; set; }
    }   
}
