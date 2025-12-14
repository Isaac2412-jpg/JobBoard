namespace JobBoard.Components.Auth
{
    public class SimpleAuthService
    {
        public bool IsLoggedIn { get; private set; } = false;
        public string? CurrentUserEmail { get; private set; }

        private const string HardEmail = "test@jobboard.com";
        private const string HardPassword = "123456";

        public bool Login(string email, string password)
        {
            if (email == HardEmail && password == HardPassword)
            {
                IsLoggedIn = true;
                CurrentUserEmail = email;
                return true;
            }

            return false;
        }

        public void Logout()
        {
            IsLoggedIn = false;
            CurrentUserEmail = null;
        }
    }
}
