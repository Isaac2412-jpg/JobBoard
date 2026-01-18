using JobBoard.Components.Domain;

public class Application : BaseDomainModel
{
    public DateTime DateApplied { get; set; }
    public string? Status { get; set; }
    public int JobListingId { get; set; }
    public JobListing JobListing { get; set; } = default!;
    public string JobSeekerId { get; set; } = default!;          // Identity GUID string
    public JobBoard.Data.JobBoardUser JobSeeker { get; set; } = default!;
}
