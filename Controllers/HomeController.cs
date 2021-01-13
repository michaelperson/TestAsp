using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MaPremierAppWeb.Controllers
{
    

    public class HomeController : Controller
    {
        //  http://localhost:54042/Home/Index/45
        //  Le moteur MVC
        //
        //  HomeController ctl = new HomeController()
        //  return ctl.Index(45);
        //  Return ==> Vers le navigateur (httpResponse)
        public ViewResult Index(int id=42 )
        {             
            return View();
        }

        //  http://localhost:54042/Home/About
        //  Le moteur MVC
        //
        //  HomeController ctl = new HomeController()
        //  return ctl.About();
        //  Return ==> Vers le navigateur (httpResponse)
        public ActionResult About( )
        {
            ViewBag.Message = $"Your application description page.";

            return View();
        }

        //  http://localhost:54042/Home/Contact
        //  Le moteur MVC
        //
        //  HomeController ctl = new HomeController()
        //  return ctl.Contact();
        //  Return ==> Vers le navigateur (httpResponse)
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public string Equipe()
        {
            return "Voici l'équipe de dev";
        }
    }
}