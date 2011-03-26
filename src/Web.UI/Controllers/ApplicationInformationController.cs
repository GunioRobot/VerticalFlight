using System.Linq;
using System.Web.Mvc;
using VerticalFlight.Core.Data;
using VerticalFlight.Core.Domain;

namespace Web.UI.Controllers
{
    public class ApplicationInformationController : Controller
    {
        readonly Repository _repository;

        public ApplicationInformationController(Repository repository)
        {
            _repository = repository;
        }

        public ActionResult List()
        {
            return View(_repository.All<ApplicationInformation>().ToList());
        }

        public ActionResult Create()
        {
            return View(new ApplicationInformation());
        }

        [HttpPost]
        public ActionResult Create(ApplicationInformation appInfo)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Unable to save ApplicationInformation.");
                return View(appInfo);
            }
            _repository.Save(appInfo);
            return RedirectToAction("List");
        }
    }
}
