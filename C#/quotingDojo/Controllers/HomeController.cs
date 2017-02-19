using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quotingDojo.Factory;
using quotingDojo.Models;


namespace quotingDojo.Controllers{
    public class HomeController : Controller{
        private readonly PostsFactory postsFactory;
        public HomeController(){
            postsFactory = new PostsFactory();
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View("Index");
        }
        [HttpPostAttribute("quotes")]
        public IActionResult Quotes(Posts post){
            if (ModelState.IsValid){
                postsFactory.Add(post);
                return RedirectToAction("Quotes");
            }
            ViewBag.errors = ModelState.Values.ToList();
            return View("Index");
        }
        [HttpGetAttribute("quotes")]
        public IActionResult Quotes() {
            ViewBag.quotes = postsFactory.FindAll();
            return View("Quotes");
        }
    }
}
