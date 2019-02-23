using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using view_model_fun.Models;

namespace view_model_fun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            User bob = new User();
            return View(bob);
        }

        [HttpGet("firstname")]
        public IActionResult FirstName()
        {
            User bob = new User();
            return View("firstname", bob.FirstName);
        }

        [HttpGet("lastname")]
        public IActionResult LastName()
        {
            User bob = new User();
            return View("lastname", bob.LastName);
        }

        [HttpGet("fullname")]
        public IActionResult FullName()
        {
            User bob = new User();
            string name = $"{bob.FirstName} {bob.LastName}";
            return View("fullname", name);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            User bob = new User();
            return View("numbers", bob.FavoriteNumbers);
        }

        [HttpGet("friends")]
        public IActionResult BestFriends()
        {
            User bob = new User();
            return View("friends", bob.BestFriends);
        }

        [HttpGet("all")]
        public IActionResult All()
        {
            User bob = new User();
            return View("allinfo", bob);
        }
    }
}
