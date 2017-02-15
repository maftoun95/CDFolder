using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ranPass.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            int? Attempts = HttpContext.Session.GetInt32("Attempts");
            if (Attempts = null){
                Attempts = 0;
                HttpContext.Session.
            }
            // ViewBag.num
            // ViewBag.attempts
            return View();
        }

        [HttpPost]
        [Route("generate")]
        public IActionResult Generate() {
            Random rand = new Random();
            string randVals = "ABCDEFGHIJKLMNOP";
            string randstring = "";
            for (int i = 0; i < 14; i++){
                randstring+= randVals[rand.Next(0,randVals.Length)];
            }
            HttpContext.Session.SetString("randstring", randstring);
            HttpContext.Session.SetInt32("Attempts", (int)HttpContext.Session.GetInt32("Attempts")+1);
            return RedirectToAction("Index");
        }
    }
}
