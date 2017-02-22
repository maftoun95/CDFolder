using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace loginReg.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("success")]
        public IActionResult Success()
        {
            if (HttpContext.Session.GetString("loggedIn") == "true"){
                return View("Success");
            }
            TempData["fail"]="Please log in before proceeding";
            return RedirectToAction("Index", "User");
        }
    }
}
