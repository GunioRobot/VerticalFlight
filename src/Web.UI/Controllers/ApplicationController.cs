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

        [HttpPost] +
        public ActionResult Create(ApplicationCreationModel appModel)
        {
            var application =
                _repository.All<Application>().FirstOrDefault(app => app.ApplicationID == appModel.ApplicationID);

            Mapper.CreateMap<ApplicationCreationModel, Application>();
            application = Mapper.Map(appModel, application);
            if (application != null)
            {
                _repository.Save(application);
            }
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
            var inserted = new EducationTraining {Application = {ApplicationID = appId}};

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




        [GridAction]
        public ActionResult _AirmanSelectAjaxEditing(int appId)
        {
            return View("Create", new GridModel(_repository.All<EducationTraining>().Where(et => et.Application.ApplicationID == appId)));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _AirmanInsertAjaxEditing(int appId)
        {
            var inserted = new AirmanCertificate { Application = {ApplicationID = appId}};

            TryUpdateModel(inserted);

            _repository.Save<AirmanCertificate>(inserted);

            return View("Create", new GridModel(_repository.All<AirmanCertificate>().Where(ac => ac.Application.ApplicationID == appId)));
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _AirmanUpdateAjaxEditing(int id, int appId)
        {
            var updated = _repository.All<AirmanCertificate>().Where<AirmanCertificate>(ac => ac.AirmanCertificateID == id).FirstOrDefault<AirmanCertificate>();

            TryUpdateModel(updated);

            _repository.Save<AirmanCertificate>(updated);

            return View("Create", new GridModel(_repository.All<AirmanCertificate>().Where(ac => ac.Application.ApplicationID == appId)));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _AirmanDeleteAjaxEditing(int id, int appId)
        {
            var deleted = _repository.All<AirmanCertificate>().Where<AirmanCertificate>(ac => ac.AirmanCertificateID == id).FirstOrDefault<AirmanCertificate>();
            _repository.Delete<AirmanCertificate>(deleted);

            return View("Create", new GridModel(_repository.All<AirmanCertificate>().Where(et => et.Application.ApplicationID == appId)));
        }




        [GridAction]
        public ActionResult _FlightSelectAjaxEditing(int appId)
        {
            return View("Create", new GridModel(_repository.All<FlightExperience>().Where(et => et.Application.ApplicationID == appId)));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _FlightInsertAjaxEditing(int appId)
        {
            var inserted = new FlightExperience { Application = { ApplicationID = appId } };

            TryUpdateModel(inserted);

            _repository.Save<FlightExperience>(inserted);

            return View("Create", new GridModel(_repository.All<FlightExperience>().Where(fx => fx.Application.ApplicationID == appId)));
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _FlightUpdateAjaxEditing(int id, int appId)
        {
            var updated = _repository.All<FlightExperience>().Where(fx => fx.FlightExperienceID == id).FirstOrDefault<FlightExperience>();

            TryUpdateModel(updated);

            _repository.Save<FlightExperience>(updated);

            return View("Create", new GridModel(_repository.All<FlightExperience>().Where(fx => fx.Application.ApplicationID == appId)));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _FlightDeleteAjaxEditing(int id, int appId)
        {
            var deleted = _repository.All<FlightExperience>().Where<FlightExperience>(fx => fx.FlightExperienceID == id).FirstOrDefault<FlightExperience>();
            _repository.Delete<FlightExperience>(deleted);

            return View("Create", new GridModel(_repository.All<FlightExperience>().Where(fx => fx.Application.ApplicationID == appId)));
        }





        [GridAction]
        public ActionResult _RefSelectAjaxEditing(int appId)
        {
            return View("Create", new GridModel(_repository.All<ProfessionalReference>().Where(r => r.Application.ApplicationID == appId)));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RefInsertAjaxEditing(int appId)
        {
            var inserted = new ProfessionalReference { Application = { ApplicationID = appId } };

            TryUpdateModel(inserted);

            _repository.Save<ProfessionalReference>(inserted);

            return View("Create", new GridModel(_repository.All<ProfessionalReference>().Where(r => r.Application.ApplicationID == appId)));
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RefUpdateAjaxEditing(int id, int appId)
        {
            var updated = _repository.All<ProfessionalReference>().Where<ProfessionalReference>(r => r.ProfessionalReferenceID == id).FirstOrDefault<ProfessionalReference>();

            TryUpdateModel(updated);

            _repository.Save<ProfessionalReference>(updated);

            return View("Create", new GridModel(_repository.All<ProfessionalReference>().Where(r => r.Application.ApplicationID == appId)));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RefDeleteAjaxEditing(int id, int appId)
        {
            var deleted = _repository.All<ProfessionalReference>().Where<ProfessionalReference>(r => r.ProfessionalReferenceID == id).FirstOrDefault<ProfessionalReference>();
            _repository.Delete<ProfessionalReference>(deleted);

            return View("Create", new GridModel(_repository.All<ProfessionalReference>().Where(fx => fx.Application.ApplicationID == appId)));
        }
    }
}
