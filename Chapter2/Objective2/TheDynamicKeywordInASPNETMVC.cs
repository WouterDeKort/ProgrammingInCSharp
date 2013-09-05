using System;
using System.ComponentModel;
using System.Web.Mvc;
using Startup;

namespace Chapter2.Objective2
{
    [Description("Listing 2-30 The dynamic keyword in ASP.NET MVC.")]
    internal class TheDynamicKeywordInASPNETMVC : ISample
    {
        public void Run()
        {
            var controller = new MyController();

            var result = (ViewResult) controller.Index();

            Console.WriteLine(result.ViewBag.MyDynamicValue);
        }

        private class MyController : Controller
        {
            public ActionResult Index()
            {
                ViewBag.MyDynamicValue = "This property is not statically typed";
                return View();
            }
        }
    }
}