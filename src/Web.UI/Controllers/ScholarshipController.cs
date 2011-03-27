using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        //
        // GET: /Scholarship/
        public ActionResult Apply()
        {
            ViewBag.Message = "Select a scholarship from below list to start the application process.";
            ScholarshipInfo scholarshipInfo = new ScholarshipInfo();
            
            return View(_repository.All<ScholarshipInfo>().ToList());
        }

    }
}
