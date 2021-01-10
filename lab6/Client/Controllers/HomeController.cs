using Laba4ASPModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        private Laba4ASPEntities1 wcf;

        public HomeController()
        {
            wcf = new Laba4ASPEntities1(new Uri("https://localhost:44378/WcfDataService2.svc/"));
        }
        //public ActionResult Index()
        //{
        //    var data = wcf.NOTEs.ToList();
        //    foreach (NOTE note in data)
        //    {
        //        Random rnd = new Random();

        //        int value = rnd.Next();
        //        note.subject = "Subj" + value;
        //        wcf.UpdateObject(note);
        //    }
        //    wcf.SaveChanges();
        //    wcf.AddToNOTEs(new NOTE() { note1 = 1, student_id = 1, subject = "bio" });
        //    wcf.SaveChanges();

        //    return View(wcf.NOTEs.ToList());
        //}
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
    }
}