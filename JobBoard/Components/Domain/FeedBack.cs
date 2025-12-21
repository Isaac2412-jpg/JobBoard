namespace JobBoard.Components.Domain
{
    public class FeedBack : BaseDomainModel
    {
        public string Message { get; set; } = default!;

        public DateTime DateSubmitted { get; set; }

        public string IdentityUserId { get; set; } = default!;
        public JobBoard.Data.JobBoardUser User { get; set; } = default!;
    }
}
