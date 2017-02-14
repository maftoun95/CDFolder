using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace SurveyApp.Controllers{
    public class HelloController : Controller{
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View("index");
        }
        [HttpGet]
        [Route("result")]
        public IActionResult Result(string name, string loc, string lang, string comm,){
            ViewBag.name = name;
            ViewBag.loc = loc;
            ViewBag.lang = lang;
            ViewBag.comm = comm;
            return View("result");
        }

    }
}