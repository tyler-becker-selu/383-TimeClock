using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clock.DAL;
using Clock.Models;
using System.Web.Security;
using System.Web.Helpers;

namespace Clock.Controllers
{
    public class AccountController : Controller
    {
        ClockContext db = new ClockContext();

        //pulls LogIn View
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();           

        }

  //***************************************************************************************************************************************************************//     

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(Models.LoginViewModel user, string returnUrl)
        {
            bool _LogInFlag;
            if (ModelState.IsValid)
            {
                //calls function to check if username and password are correct
                _LogInFlag = IsValid(user.Username, user.Password);

                if (_LogInFlag == true)
                {
                    //set authentication cookie and redirect
                    FormsAuthentication.SetAuthCookie(user.Username, false);
                    using(var db = new ClockContext())
                    {
                        var un = db.Users.FirstOrDefault(u => u.Username == user.Username);
                        if(un.RoleId == 1)
                        {
                            return RedirectToAction("Index", "User");
                            
                        }

                        else
                        {

                            return RedirectToAction("Index","Home");
                        }                        
                    }                    
                }

                else
                {
                    //error if failed
                    ModelState.AddModelError("", "Invalid Username or Password.");
                }
            }
           

            // It should not get this far
            return View();
        }

//******************************************************************************************************************************************************************************************//
        [HttpPost]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LogIn", "Account");
        }


//**************************************************************************************************************************************************************************************//
        //Checs username and password
        private bool IsValid(string username, string password)
        {

            bool isValid = false;

            using(var db = new ClockContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Username == username);

                if (user != null)
                {

                    if (Crypto.VerifyHashedPassword(user.Password,password) == true)
                    {
                        isValid = true;
                    }
                }


            }

            return isValid;
        }

        //*****************************************************************************************************************************************************************//


        [Authorize]
        [HttpGet]
        public ActionResult ManageUser()
        {
                       

            return View();
        }

       [HttpPost]
        public ActionResult ManageUser(Models.ManageUserViewModel change)
        {

            string currentUser = FormsAuthentication.Decrypt(Request.Cookies[FormsAuthentication.FormsCookieName].Value).Name;
           var user = db.Users.First(u => u.Username == currentUser);
          

            if (ModelState.IsValid && Crypto.VerifyHashedPassword(user.Password,change.OldPassword) ==true)
            {                

                var npass = Crypto.HashPassword(change.NewPassword);
                user.Password = npass;
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {

                ModelState.AddModelError("", "There was an Error");
                

            }

            return View();

           
        }


    }


    



}