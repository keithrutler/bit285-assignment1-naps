using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bit285_assignment1_naps.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bit285_assignment1_naps.Controllers
{
    public class NapsController : Controller
    {
        // Entry Page Action
        [HttpGet]
        public IActionResult Account_Info()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Account_Info(User user)
        {
            return RedirectToAction("Password_Info", user);
        }

        // Password Information Action
        [HttpGet]
        public IActionResult Password_Info(User user)
        {
            return View(user);
        }
        [HttpPost]
        public IActionResult Password_Info(User user, int fake)
        {
            return RedirectToAction("Select_Password", user);
        }

        // Select Password Action
        [HttpGet]
        public IActionResult Select_Password(User user, PasswordSuggestionService PSS)
        {
            user.Password = PSS.GeneratePassword(user);
            return View(user);
        }
        [HttpPost]
        public IActionResult Select_Password(User user, int fake)
        {
            return RedirectToAction("Confirm_Account", user);
        }
        
        // Confirm Account Action
        [HttpGet]
        public IActionResult Confirm_Account(User user)
        {
            return View(user);
        }
        [HttpPost]
        public IActionResult Confirm_Account(User user, int fake)
        {
            return RedirectToAction("Login", user);
        }

        // Login Action
        [HttpGet]
        public IActionResult Login(User user)
        {
            return View(user);
        }
    }
}
