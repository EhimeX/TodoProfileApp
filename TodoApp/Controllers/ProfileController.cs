using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class ProfileController : Controller
    {
        private List<Profile> profileStore;

        public ProfileController()
        {
             this.profileStore = new List<Profile> {
                new Profile { FirstName = "Ehueriken", LastName = "Obuse", Age = 18 },
                new Profile { FirstName = "Ehimah", LastName = "Obuse", Age = 16 },
                new Profile { FirstName = "Oga", LastName = "Emma", Age = 50 }
            };
        }

        public IActionResult Index()
        {
            return View(this.profileStore);
        }

        public IActionResult Details(int id)
        {
            var viewModel = this.profileStore[id];

            return View(viewModel);
        }
    }
}
