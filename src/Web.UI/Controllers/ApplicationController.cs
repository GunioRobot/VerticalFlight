using System;
using System.Web.Mvc;
using Telerik.Web.Mvc;
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

        public ActionResult Create(int id)
        {
            ViewData["ajax"] = true;
            return View(new ApplicationCreationModel { ScholarshipID = id });
        }

        public ActionResult EditingServerSide()
        {
            return View("Create");
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EducationInsert(int id)
        {
            //EducationTraining education = _repository.(et => et.EducationTrainingID == educationTrainingId);

            //TryUpdateModel(product);
            //SessionProductRepository.Update(product);
            //return View(new GridModel(SessionProductRepository.All()));
            throw new NotImplementedException("Getting there...");
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult EducationUpdate(int id)
        {
            ////Create a new instance of the EditableProduct class.
            //EditableProduct product = new EditableProduct();
            ////Perform model binding (fill the product properties and validate it).
            //if (TryUpdateModel(product))
            //{
            //    //The model is valid - insert the product.
            //    SessionProductRepository.Insert(product);
            //}
            ////Rebind the grid
            //return View(new GridModel(SessionProductRepository.All()));
            throw new NotImplementedException("Getting there...");
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EducationDelete(int id)
        {
            ////Find a customer with ProductID equal to the id action parameter
            //EditableProduct product = SessionProductRepository.One(p => p.ProductID == id);
            //if (product != null)
            //{
            //    //Delete the record
            //    SessionProductRepository.Delete(product);
            //}

            ////Rebind the grid
            //return View(new GridModel(SessionProductRepository.All()));
            throw new NotImplementedException("Getting there...");
        }
    }
}
