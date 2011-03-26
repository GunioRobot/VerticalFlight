using System.Web.Mvc;
using Web.UI.Models;

namespace Web.UI.Controllers
{
    public class ApplicationController : Controller
    {
        public ActionResult Create()
        {

            return View(new ApplicationCreationModel());
        }
    }
}
