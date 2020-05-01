using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult GetMyView()
        {
            return View("Index");
        }

        //public string GetMyName()
        //{
        //    return "Manav";
        //}

        public string GetMyName(string id, string name)
        {
            //... Comment Added in GIT ...
            return "My Id is: " + id +" my name is: "+ name;
        }
    }
}
