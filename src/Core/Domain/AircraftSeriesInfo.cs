using System;


namespace VerticalFlight.Core.Domain
{
    class AircraftSeriesInfo
    {
        public virtual int AircraftSeriesInfoID { get; set; }
        public virtual int ApplicationID { get; set; }
        public virtual string Details { get; set; }
        public virtual string MedicalCertificateClass { get; set; }
        public virtual DateTime MedicalCertificateDate { get; set; }
        public virtual string MedicalCertificatePath { get; set; }
        public virtual DateTime UploadDateTime { get; set; }
    }

}