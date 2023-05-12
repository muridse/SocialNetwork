using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Models;
using SocialNetwork.Repository;

namespace SocialNetwork.Controllers
{
    public class UsersController : Controller
    {
        

        public IActionResult Index()
        {
            return View(UsersRepository._users);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string Name, string Email, string Password)
        {
            var user = new User();
            user.Name = Name;
            user.Email = Email; 
            user.Password = Password;
            user.Id = UsersRepository._users.Count;
            UsersRepository.AddUser(user);
            return RedirectToAction(nameof(Index));
        }
    }
}
