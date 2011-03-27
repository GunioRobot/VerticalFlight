using System;
using System.Web.Mvc;
using Telerik.Web.Mvc;
using VerticalFlight.Core.Data;
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

        public ActionResult Create(int id)
        {
            var application = new Application { ScholarshipID = id, UserID = _membershipService.GetUserIdFor(User.Identity.Name), ApplicationDate = DateTime.Now };
            _repository.Save<Application>(application);

            Mapper.CreateMap<Application, ApplicationCreationModel>();
            var appModel = Mapper.Map<Application, ApplicationCreationModel>(application);

            return View(appModel);
        }

        [GridAction]
        public ActionResult _EducationSelectAjaxEditing(int appId)
        {
            return View("Create", new GridModel(_repository.All<EducationTraining>().Where(et => et.ApplicationID == appId)));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _EducationInsertAjaxEditing(int appId)
        {
            var inserted = new EducationTraining();

            TryUpdateModel(inserted);

            _repository.Save<EducationTraining>(inserted);

            return View("Create", new GridModel(_repository.All<EducationTraining>().Where(et => et.ApplicationID == appId)));
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _EducationUpdateAjaxEditing(int id, int appId)
        {
            var updated = _repository.All<EducationTraining>().Where<EducationTraining>(et => et.EducationTrainingID == id).FirstOrDefault<EducationTraining>();

            TryUpdateModel(updated);

            _repository.Save<EducationTraining>(updated);

            return View("Create", new GridModel(_repository.All<EducationTraining>().Where(et => et.ApplicationID == appId)));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _EducationDeleteAjaxEditing(int id, int appId)
        {
            var deleted = _repository.All<EducationTraining>().Where<EducationTraining>(et => et.EducationTrainingID == id).FirstOrDefault<EducationTraining>();
            _repository.Delete<EducationTraining>(deleted);

            return View("Create", new GridModel(_repository.All<EducationTraining>().Where(et => et.ApplicationID == appId)));
        }
    }
}
