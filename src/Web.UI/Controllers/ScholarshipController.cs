using System.Linq;
using System.Web.Mvc;
using VerticalFlight.Core.Data;
using VerticalFlight.Core.Domain;

namespace Web.UI.Controllers
{
    public class ScholarshipController : Controller
    {
        readonly Repository _repository;

        public ScholarshipController(Repository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View(_repository.All<ScholarshipInfo>().ToList());
        }
    }
}
