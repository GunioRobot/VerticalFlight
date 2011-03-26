using System;
using System.Linq;
using System.Web.Mvc;
using VerticalFlight.Core.Data;
using VerticalFlight.Core.Domain;

namespace Web.UI.Controllers
{
    public class HeartbeatController : Controller
    {
        readonly Repository _repository;

        public HeartbeatController(Repository repository)
        {
            _repository = repository;
        }

        public ActionResult Save()
        {
            try
            {
                var hb = new Heartbeat { Name = "Test" };
                _repository.Save(hb);
                ViewBag.IsSuccessful = "Successful";
            }
            catch (Exception)
            {
                ViewBag.IsSuccessful = "Unsuccessful";
                throw;
            }

            return View();
        }

        public ActionResult List()
        {
            return View(_repository.All<Heartbeat>().FirstOrDefault(x => x.HeartbeatID == 1));
        }
    }
}
