using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using wall.Factory;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using wall.Models;

namespace wall.Controllers
{
    public class UserController : Controller {
        private readonly UserFactory userFactory;
        public UserController(UserFactory user) {
            userFactory = user;
        }
        
// RENDER INDEX
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

// REGISTER A NEW USER
        [HttpPost]
        [Route("")]
        public IActionResult RegisterUser(User user) {
            bool alreadyHere = userFactory.isRegistered(user.Email);
            if (alreadyHere){
                    ViewBag.regFail = "This email is already in use, try another";
                    return View("Index", user);
                } 
            if (ModelState.IsValid){
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                userFactory.Add(user);

                HttpContext.Session.SetString("loggedIn", "true");
                User brobro = userFactory.FetchUser(user.Email);
                HttpContext.Session.SetString("first", brobro.FirstName);
                HttpContext.Session.SetInt32("uid", brobro.id);
                // HttpContext.Session.GetInt32
                // HttpContext.Session.GetString
                return RedirectToAction("TheWall", "Wall");
            }
            return View("Index");
        }

// LOG IN A USER 
        [HttpPost]
        [Route("login")]
        public IActionResult LoginUser(User user) {
            if(user.Email != null && user.Password != null){
                User DBCheck = userFactory.FetchUser(user.Email);
                if (DBCheck != null && user.Password != null){
                    var Hasher = new PasswordHasher<User>();
                    if(0 != Hasher.VerifyHashedPassword(DBCheck, DBCheck.Password, user.Password)){
                        HttpContext.Session.SetString("loggedIn", "true");
                        User brobro = userFactory.FetchUser(user.Email);
                        HttpContext.Session.SetString("first", brobro.FirstName);
                        HttpContext.Session.SetInt32("uid", brobro.id);
                        return RedirectToAction("TheWall", "Wall");
                    }
                }
            }
            TempData["errors"]="Could not match the provided email & password, please try again";
            return RedirectToAction("Index");
        }
//POST A COMMENT TO THE WALL
        [HttpPost]
        [Route("addComment/{uid}")]
        public IActionResult AddComment(Message messi){
            int uid = (int)HttpContext.Session.GetInt32("uid");
            // User brobro = userFactory.UIDFetcher(uid);
            userFactory.addMessage(messi, uid);
            return RedirectToAction("TheWall", "Wall");
        }







// LOG OUT
        [HttpGet]
        [Route("logout")]
        public IActionResult Logout(){

            HttpContext.Session.SetString("loggedIn", "false");
            return RedirectToAction("Index");
        }
    }
}
