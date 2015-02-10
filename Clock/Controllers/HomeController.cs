using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clock.DAL;
using Clock.Models;
using System.Web.Security;

namespace Clock.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        ClockContext _db = new ClockContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Portal(string userName)
        {

            if (_db.Users.Where(r => r.Username.Equals(userName)).Any() && userName.Equals(FormsAuthentication.Decrypt(Request.Cookies[FormsAuthentication.FormsCookieName].Value).Name))
            {
                    var user = _db.Users.Where(r => r.Username.Equals(userName)).First();
                    return View(user);   
            
            }

            return HttpNotFound();
        }
       
    }
      
}