using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewwModels.Models;

namespace NewModels.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            

            return View("Index", "hello there");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet("Numbers")]
        public IActionResult Numbers()
        {
            int[] number = new int[]{
                1,2,3,4,5,6,7,8,9
            };
            return View(number);
        }

        [HttpGet("Users")]
        public IActionResult Users()
        {
            User person1 = new User()
            {
                FirstName = "Blaine",
                LastName = "Peoples"
            };
            User person2 = new User()
            {
                FirstName = "Susan",
                LastName = "Junbug"
            };

            User person3 = new User()
            {
                FirstName = "Harold",
                LastName = "Lavendar"
            };
            User person4 = new User()
            {
                FirstName = "John",
                LastName = "Smith"
            };

            List<User> ThePeeps = new List<User>()
            {
                person1,person2,person3,person4
            };
            return View(ThePeeps);
        }


        [HttpGet("User")]
        public IActionResult User()
        {
            User person1 = new User()
            {
                FirstName = "Blaine",
                LastName = "Peoples"
            };
            return View(person1);
        }
    }
}
