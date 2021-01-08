using System;
using System.Web.Mvc;
using SessionStateAttributeInMVC.Models;
using System.Web.SessionState;

namespace SessionStateAttributeInMVC.Controllers
{
    [ SessionState( SessionStateBehavior.Disabled)]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(EmpModel obj)
        {
            //store the session from user input and display into the view if session is enabled.
            Session["Name"] = Convert.ToString(obj.Name);
            return View();

        }
    }
}