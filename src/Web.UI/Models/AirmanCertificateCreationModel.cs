using System;
using System.Web;

namespace Web.UI.Models
{
    public class AirmanCertificateCreationModel
    {
        public int AirmanCertificateID { get; set; }
        public int ApplicationID { get; set; }
        public string ClassCategory { get; set; }
        public string Ratings { get; set; }
        public DateTime DateObtained { get; set; }
        public string AircraftType { get; set; }

        public HttpPostedFileBase CertificateFile { get; set; }
    }
}