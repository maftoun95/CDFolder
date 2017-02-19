using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using validatingForms.Models;

namespace validatingForms.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.errors = "";
            return View();
        }

        [HttpPostAttribute("")]
        public IActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                System.Console.WriteLine("sure, bro");
                TempData["fname"] = user.FirstName;
                TempData["lname"] = user.LastName;
                TempData["age"] = user.Age;
                TempData["email"] = user.Email;
                TempData["password"] = user.Password;
                return RedirectToAction("Success");
            }
            ViewBag.errors = ModelState.Values.ToList();
            System.Console.WriteLine("errors abound");
            return View();
        }

        [HttpGetAttribute("success")]
        public IActionResult Success()
        {
            ViewBag.fname = TempData["fname"];
            ViewBag.lname = TempData["lname"];
            ViewBag.age = TempData["age"];
            ViewBag.email = TempData["email"];
            ViewBag.password = TempData["password"];
            return View();
        }
    }
}