using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Models;

namespace SocialNetwork.Controllers
{
    public class UsersController : Controller
    {
        private readonly List<User> _users = new List<User>();

        public IActionResult Index()
        {
            return View(_users);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            _users.Add(user);
            return RedirectToAction(nameof(Index));
        }
    }
}
