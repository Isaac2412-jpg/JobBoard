namespace JobBoard.Components.Domain
{
    public class JobListing : BaseDomainModel
    {
        public required string Title { get; set; }

        public required string JobType { get; set; }
        
        public required string Industry { get; set; }
        
        public required int Salary { get; set; }

        public required string Location { get; set; }

        public required string Description { get; set; }

        public required string Requirements { get; set; }

        public DateTime DatePosted { get; set; }

        public int EmployerId { get; set; }
    }
}
