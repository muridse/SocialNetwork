using SocialNetwork.Models;

namespace SocialNetwork.Repository
{
    public static class UsersRepository
    {
        public static List<User> _users = new List<User>();
        public static void AddUser(User user)=> _users.Add(user);
    }
}
