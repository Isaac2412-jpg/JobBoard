namespace JobBoard.Components.Domain
{
    public class JobListing : BaseDomainModel
    {
        public string Title { get; set; } = default!;

        public string JobType { get; set; } = default!;
        
        public string Industry { get; set; } = default!;
        
        public int Salary { get; set; }

        public string Location { get; set; } = default!;

        public string Description { get; set; } = default!;

        public string Requirements { get; set; } = default!;

        public DateTime DatePosted { get; set; }

        public int EmployerId { get; set; } = default!;
        public Employer Employer { get; set; } = default!;
    }
}
