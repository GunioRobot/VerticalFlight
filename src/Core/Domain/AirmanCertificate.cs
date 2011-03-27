using System;

namespace VerticalFlight.Core.Domain
{
    public class AirmanCertificate
    {
        public virtual int AirmanCertificateID { get; set; }
        public virtual int ApplicationID { get; set; }
        public virtual string ClassCategory { get; set; }
        public virtual string Ratings { get; set; }
        public virtual DateTime DateObtained { get; set; }
        public virtual string AircraftType { get; set; }
    }
}
