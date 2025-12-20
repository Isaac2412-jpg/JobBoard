namespace JobBoard.Components.Domain
{
    public class FeedBack : BaseDomainModel
    {
        public string Message { get; set; }

        public DateTime DateSubmitted { get; set; }

        public int UserId { get; set; }
    }
}
