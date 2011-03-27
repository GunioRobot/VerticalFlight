using System;
using System.Web.Mvc;
using VerticalFlight.Core.Data;
using VerticalFlight.Core.Domain;

namespace Web.UI.Controllers
{
    public class HomeController : Controller
    {
        readonly Repository _repository;

        public HomeController(Repository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the Scholarship Application Process!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
