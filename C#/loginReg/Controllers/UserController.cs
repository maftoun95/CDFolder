using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using loginReg.Models;
using Microsoft.AspNetCore.Mvc;

namespace loginReg.Controllers
{
    public class UserController : Controller
    {
        // GET: /Home/
        [HttpPost]
        [Route("register")]
        public IActionResult RegisterUser(User user)
        {
            return View("Success");
        }
        [HttpPost]
        [Route("login")]
        public IActionResult LoginUser(User user)
        {
            return View("Success");
        }
    }
}
