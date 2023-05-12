using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Models;
using SocialNetwork.Repository;

namespace SocialNetwork.Controllers
{
    public class MessagesController : Controller
    {

        public IActionResult Index()
        {
            return View(MessagesRepository._messages);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(int User, string Text)
        {
            var message = new Message();
            message.UserId = User;
            message.Text = Text;
            message.CreatedAt = DateTime.Now;
            MessagesRepository.AddMessage(message);

            return RedirectToAction(nameof(Index));
        }
    }
}
