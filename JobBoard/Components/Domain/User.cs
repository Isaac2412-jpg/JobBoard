namespace JobBoard.Components.Domain
{
    public class User : BaseDomainModel
    {
        public required string UserName { get; set; }

        public required string Email { get; set; }

        public required string Role { get; set; }

        public required string AccountType { get; set; }

    }
}
