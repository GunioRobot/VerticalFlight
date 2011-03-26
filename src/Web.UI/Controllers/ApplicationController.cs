using System.Web.Mvc;
using VerticalFlight.Core.Data;
using Web.UI.Models;

namespace Web.UI.Controllers
{
    public class ApplicationController : Controller
    {
        readonly Repository _repository;

        public ApplicationController(Repository repository)
        {
            _repository = repository;
        }

        public ActionResult Create()
        {
            return View(new ApplicationCreationModel());
        }
    }
}
