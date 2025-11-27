namespace nutritionist
{
    public class UserSession
    {
        public UserSession(string userId, string userName, string role)
        {
            UserId = userId;
            UserName = userName;
            Role = role;
        }

        public string UserId { get; }
        public string UserName { get; }
        public string Role { get; }

        public bool IsAdmin =>
            string.Equals(Role, "ADMIN", System.StringComparison.OrdinalIgnoreCase);
    }
}
