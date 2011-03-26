using System;
using System.Collections.Generic;

namespace VerticalFlight.Core.Domain
{
    public class Application
    {
        public virtual int ApplicationID { get; set; }
        public virtual int ScholarshipID { get; set; }
        public virtual string UserID { get; set; }
        public virtual ApplicationInformation ApplicationInformation { get; set; }
        public virtual EmploymentInfo EmploymentInfo { get; set; }
        public virtual IList<FlightExperience> FlightExperience { get; set; }
        public virtual DateTime ApplicationDate { get; set; }
    }
} 