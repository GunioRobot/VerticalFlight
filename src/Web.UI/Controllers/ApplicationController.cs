using System.Web.Mvc;
using VerticalFlight.Core.Data;
using Web.UI.Models;
using Telerik.Web.Mvc;
using Telerik.Web.Mvc.UI;
using VerticalFlight.Core.Domain;
using System.Linq;

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
            ViewData["ajax"] = true;
            return View(new ApplicationCreationModel());
        }
                
        //[GridAction]
        //public ActionResult _SelectAjaxEditing()
        //{
        //    return View(new GridModel(_repository.All<EducationTraining>()));
        //}

        //[AcceptVerbs(HttpVerbs.Post)]
        //[CultureAwareAction]
        //[GridAction]
        //public ActionResult _SaveAjaxEditing(int id)
        //{
        //    EducationTraining education = _repository.(et => et.EducationTrainingID == id);

        //    TryUpdateModel(product);
        //    SessionProductRepository.Update(product);
        //    return View(new GridModel(SessionProductRepository.All()));
        //}
        //[AcceptVerbs(HttpVerbs.Post)]
        //[CultureAwareAction]
        //[GridAction]
        //public ActionResult _InsertAjaxEditing()
        //{
        //    //Create a new instance of the EditableProduct class.
        //    EditableProduct product = new EditableProduct();
        //    //Perform model binding (fill the product properties and validate it).
        //    if (TryUpdateModel(product))
        //    {
        //        //The model is valid - insert the product.
        //        SessionProductRepository.Insert(product);
        //    }
        //    //Rebind the grid
        //    return View(new GridModel(SessionProductRepository.All()));
        //}
        //[AcceptVerbs(HttpVerbs.Post)]
        //[GridAction]
        //public ActionResult _DeleteAjaxEditing(int id)
        //{
        //    //Find a customer with ProductID equal to the id action parameter
        //    EditableProduct product = SessionProductRepository.One(p => p.ProductID == id);
        //    if (product != null)
        //    {
        //        //Delete the record
        //        SessionProductRepository.Delete(product);
        //    }

        //    //Rebind the grid
        //    return View(new GridModel(SessionProductRepository.All()));
        //}
    }
}
