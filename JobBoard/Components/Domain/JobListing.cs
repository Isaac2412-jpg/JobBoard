namespace JobBoard.Components.Domain
{
    public class JobListing : BaseDomainModel
    {
        public  string Title { get; set; }

        public  string JobType { get; set; }
        
        public  string Industry { get; set; }
        
        public int Salary { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public string Requirements { get; set; }

        public DateTime DatePosted { get; set; } 

        public int EmployerId { get; set; }
    }
}
