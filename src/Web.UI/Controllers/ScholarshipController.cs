using System.Linq;
using System.Web.Mvc;
using VerticalFlight.Core.Data;
using VerticalFlight.Core.Domain;
using VerticalFlight.Core.Services.Membership;

namespace Web.UI.Controllers
{
    public class ScholarshipController : Controller
    {
        readonly Repository _repository;
        readonly IMembershipService _membershipService;

        public ScholarshipController(Repository repository, IMembershipService membershipService)
        {
            _repository = repository;
            _membershipService = membershipService;
        }

        public ActionResult Index()
        {
            ViewBag.UserApplications = _repository.All<Application>()
                .Where(app => app.UserID == _membershipService.GetUserIdFor(User.Identity.Name))
                .ToList();
            return View(_repository.All<ScholarshipInfo>().ToList());
        }
    }
}
