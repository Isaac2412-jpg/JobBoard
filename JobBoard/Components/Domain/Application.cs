namespace JobBoard.Components.Domain
{
    public class Application : BaseDomainModel
    {
        public DateTime DateApplied { get; set; }

        public string? Status { get; set; }

        public int JobListingId { get; set; }

        public int JobSeekerId { get; set; }
    }
}
