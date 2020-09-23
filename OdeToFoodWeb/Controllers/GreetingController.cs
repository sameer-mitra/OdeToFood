using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using OdeToFood.Web.Models;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel();
            //var name = HttpContext.Request.QueryString["name"];
            model.Message = ConfigurationManager.AppSettings["Message"];
            model.Name = name ?? "no name";
            return View(model);
        }        
    }
}