using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.ActionLog = TempSite.Models.AttemptLab.Get().GetAttempts();

            return View(TempSite.Models.AttemptLab.Get().GetAttempts());
        }
        public ActionResult News()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }


        public ActionResult LogIn()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult LoginDone()
        {
            WriteAttempt("log");
            return View();
        }
        public ActionResult RegistrationDone()
        {
            WriteAttempt("reg");
            return View();
        }

        private void WriteAttempt(string action)
        {
            TempSite.Models.AttemptLab.Get().Add(
                new TempSite.Models.Attempt(Request.UserHostAddress.ToString(), action));
        }


        [ChildActionOnly]
        public string GetLogItem(TempSite.Models.Attempt item){
            return String.Format("Time: {0}  |  IP: {1}  |  Action: {2}",
                    item.mTime.ToString(), item.mIp, item.mAction);
        }

    }
}