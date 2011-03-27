using System;
using System.Linq;
using System.Web.Mvc;
using Telerik.Web.Mvc;
using VerticalFlight.Core.Data;
using VerticalFlight.Core.Domain;
using Web.UI.Models;
using VerticalFlight.Core.Services.Membership;
using AutoMapper;

namespace Web.UI.Controllers
{
    public class ApplicationController : Controller
    {
        readonly Repository _repository;
        readonly IMembershipService _membershipService;

        public ApplicationController(Repository repository, IMembershipService membershipService)
        {
            _repository = repository;
            _membershipService = membershipService;
        }

        [Authorize]
        public ActionResult Create(int id)
        {
            var loggedInUser = _membershipService.GetUserIdFor(User.Identity.Name);
            var application = _repository.All<Application>()
                .FirstOrDefault(app => app.UserID == loggedInUser && app.ScholarshipID == id);
            if(application == null)
            {
                new Application { ScholarshipID = id, UserID = _membershipService.GetUserIdFor(User.Identity.Name), ApplicationDate = DateTime.Now };
                _repository.Save(application);
            }
            Mapper.CreateMap<Application, ApplicationCreationModel>();
            var appModel = Mapper.Map<Application, ApplicationCreationModel>(application);

            return View(appModel);
        }

        [HttpPost]
        public ActionResult Create(ApplicationCreationModel appModel)
        {
            Mapper.CreateMap<ApplicationCreationModel, Application>();
            var application = Mapper.Map<ApplicationCreationModel, Application>(appModel);
            if (application != null) _repository.Save(application);
            TempData["SuccessMessage"] = "Application saved successfully";
            return View(appModel);
        }

        [GridAction]
        public ActionResult _EducationSelectAjaxEditing(int appId)
        {
            return View("Create", new GridModel(_repository.All<EducationTraining>().Where(et => et.Application.ApplicationID == appId)));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _EducationInsertAjaxEditing(int appId)
        {
            var inserted = new EducationTraining();

            TryUpdateModel(inserted);

            _repository.Save(inserted);

            return View("Create", new GridModel(_repository.All<EducationTraining>().Where(et => et.Application.ApplicationID == appId)));
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _EducationUpdateAjaxEditing(int id, int appId)
        {
            var updated = _repository.All<EducationTraining>().Where(et => et.EducationTrainingID == id).FirstOrDefault();

            TryUpdateModel(updated);

            _repository.Save(updated);

            return View("Create", new GridModel(_repository.All<EducationTraining>().Where(et => et.Application.ApplicationID == appId)));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _EducationDeleteAjaxEditing(int id, int appId)
        {
            var deleted = _repository.All<EducationTraining>().Where(et => et.EducationTrainingID == id).FirstOrDefault();
            _repository.Delete(deleted);

            return View("Create", new GridModel(_repository.All<EducationTraining>().Where(et => et.Application.ApplicationID == appId)));
        }
    }
}
