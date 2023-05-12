using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Models;

namespace SocialNetwork.Controllers
{
    public class MessagesController : Controller
    {
        private readonly List<Message> _messages = new List<Message>();

        public IActionResult Index()
        {
            return View(_messages);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Message message)
        {
            message.CreatedAt = DateTime.Now;
            _messages.Add(message);
            return RedirectToAction(nameof(Index));
        }
    }
}
