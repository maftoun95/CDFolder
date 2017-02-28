using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace wall.Controllers
{
    public class WallController : Controller
    {
        [HttpGet]
        [Route("thewall")]
        public IActionResult TheWall()
        {
            if (HttpContext.Session.GetString("loggedIn") == "true"){
                ViewBag.first = HttpContext.Session.GetString("first");
                ViewBag.uid = HttpContext.Session.GetInt32("uid");
                return View("Wall");
            }
            TempData["fail"]="Please log in before proceeding";
            return RedirectToAction("Index", "User");
        }
    }
}
