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
    public class HomeController : Controller
    {
        ClockContext _db = new ClockContext();

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Portal([Bind(Prefix = "Id")] int? userId)
        {
            
            var user = _db.Users.Find(userId);
            string currentUser = FormsAuthentication.Decrypt(Request.Cookies[FormsAuthentication.FormsCookieName].Value).Name;

            if (userId != null && (user.Username.Equals(currentUser) /*|| user.Role.Name.Equals("admin")*/))
            {
              
                    return View(user);   
            
            }

            return HttpNotFound();
        }

    }
      
}