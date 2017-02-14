using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        [Route("submitData")]
        public IActionResult result(string name, string loc, string lang, string comment){
            ViewBag.name = name;
            ViewBag.loc = loc;
            ViewBag.lang = lang;
            ViewBag.comment = comment;
            return View("result");
        }
    }
}
