using SocialNetwork.Models;
using System.Data.SqlTypes;

namespace SocialNetwork.Repository
{
    public static class MessagesRepository
    {
        public static List<Message> _messages = new List<Message>();
        public static void AddMessage(Message message) => _messages.Add(message);

    }
}
