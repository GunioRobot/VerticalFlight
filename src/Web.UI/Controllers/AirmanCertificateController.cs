using System.IO;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using VerticalFlight.Core.Data;
using VerticalFlight.Core.Domain;
using VerticalFlight.Core.Services.FileUploader;
using Web.UI.Models;

namespace Web.UI.Controllers
{
    public class AirmanCertificateController : Controller
    {
        readonly Repository _repository;
        readonly FileUploaderService _fileUploaderService;

        public AirmanCertificateController(Repository repository, FileUploaderService fileUploaderService)
        {
            _repository = repository;
            _fileUploaderService = fileUploaderService;
        }

        public ActionResult Index()
        {
            
            return View(_repository.All<AirmanCertificateCreationModel>().ToList());
        }

        public ActionResult Create()
        {
            return View(new AirmanCertificateCreationModel());
        }

        [HttpPost]
        public ActionResult Create(AirmanCertificateCreationModel airmanCertificateModel)
        {
            Mapper.CreateMap<AirmanCertificateCreationModel, AirmanCertificate>();
            var airmanCertificate = Mapper.Map<AirmanCertificateCreationModel, AirmanCertificate>(airmanCertificateModel);
            var uploadResult = _fileUploaderService.UploadFile(airmanCertificateModel.CertificateFile, Server.MapPath("~/uploads"));
            if (uploadResult.Contains("failed"))
                throw new IOException(uploadResult);
            _repository.Save(airmanCertificate);
            return RedirectToAction("Index");
        }
    }
}
