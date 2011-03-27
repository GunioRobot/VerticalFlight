using System.Web.Mvc;
using VerticalFlight.Core.Data;
using VerticalFlight.Core.Services.Membership;

namespace Web.UI.Controllers
{
    public class HomeController : Controller
    {
        readonly Repository _repository;
        readonly IMembershipService _membershipService;

        public HomeController(Repository repository, IMembershipService membershipService)
        {
            _repository = repository;
            _membershipService = membershipService;
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
