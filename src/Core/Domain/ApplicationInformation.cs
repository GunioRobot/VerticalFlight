using System;

namespace VerticalFlight.Core.Domain
{
    public class ApplicationInformation
    {
        public virtual Application Application { get; set; }
        public virtual int ApplicationInformationID { get; set; }
        public virtual string ApplicantName { get; set; }
        public virtual DateTime DOB { get; set; }
        public virtual string Citizenship { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Zip { get; set; }
        public virtual string HomePhone { get; set; }
        public virtual string MobilePhone { get; set; }
        public virtual DateTime CreatedDate { get; set; }
    }
}