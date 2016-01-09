

namespace SnNetworkWebSite.Models
{
    public class User
    {
        public User(string userId, string userName, string email, string password)
        {
            UserId = userId;
            UserName = userName;
            Email = email;
            Password = password;
        }

        public User()
        {
        }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}