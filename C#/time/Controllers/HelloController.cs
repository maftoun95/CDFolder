using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace ConsoleApplication.Controllers
{
 public class HelloController : Controller
 {
  [HttpGet]
  [Route("")]
  public IActionResult Index()
  {
    ViewBag.CurrentTime = DateTime.Now;
    return View("index");
  }
 }
}