using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace dojodachi.Controllers{
    public class HomeController : Controller{
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return RedirectToAction("WeezyFBaby");
        }
        [HttpGet]
        [Route("/weezyfbaby")]
        public IActionResult WeezyFBaby(){
            if (HttpContext.Session.GetString("alive") != "true"){
                HttpContext.Session.SetString("alive", "true");
                HttpContext.Session.SetInt32("fullness", 20);
                HttpContext.Session.SetInt32("happiness", 20);
                HttpContext.Session.SetInt32("meals", 3);
                HttpContext.Session.SetInt32("energy", 50);
                ViewBag.full = HttpContext.Session.GetInt32("fullness");
                ViewBag.happ = HttpContext.Session.GetInt32("happiness");
                ViewBag.meals = HttpContext.Session.GetInt32("meals");
                ViewBag.nrg = HttpContext.Session.GetInt32("energy");
            }
            ViewBag.full = HttpContext.Session.GetInt32("fullness");
            ViewBag.happ = HttpContext.Session.GetInt32("happiness");
            ViewBag.meals = HttpContext.Session.GetInt32("meals");
            ViewBag.nrg = HttpContext.Session.GetInt32("energy");
            return View();
        }
        [HttpPost]
        [RouteAttribute("/feed")]
        public IActionResult Feed(){
            string msg;
            int yums = (int)HttpContext.Session.GetInt32("meals");
            int fullness = (int)HttpContext.Session.GetInt32("fullness");
            Random rand = new Random();

            if (yums <=0){
                msg = "You dont have enough meals broski : (";
            }
            return View();
        }
    }
}
