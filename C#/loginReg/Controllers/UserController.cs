using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using loginReg.Factory;
using loginReg.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace loginReg.Controllers
{
    public class UserController : Controller {
        private readonly UserFactory userFactory;
        public UserController(UserFactory user) {
            userFactory = user;
        }

        [HttpPost]
        [Route("")]
        public IActionResult RegisterUser(User user)
        {
            bool notHere = userFactory.isRegistered(user.Email);
            if (notHere){
                    ViewBag.regFail = "This email is already in use, try another";
                    return View("Index", user);
                } 
            if (ModelState.IsValid){
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                userFactory.Add(user);
                HttpContext.Session.SetString("loggedIn", "true");
                return RedirectToAction("Success", "Home");

            }
            return View("Index");
        }
        [HttpPost]
        [Route("login")]
        public IActionResult LoginUser(User user)
        {
            if(user.Email != null && user.Password != null){
                User DBCheck = userFactory.FetchUser(user.Email);
                if (DBCheck != null && user.Password != null){
                    var Hasher = new PasswordHasher<User>();
                    if(0 != Hasher.VerifyHashedPassword(DBCheck, DBCheck.Password, user.Password)){
                        HttpContext.Session.SetString("loggedIn", "true");
                        return View("../Home/Success");
                    }
                }
            }
            TempData["errors"]="Could not match the provided email & password, please try again";
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("logout")]
        public IActionResult Logout(){

            HttpContext.Session.SetString("loggedIn", "false");
            return RedirectToAction("Index");
        }
    }
}
