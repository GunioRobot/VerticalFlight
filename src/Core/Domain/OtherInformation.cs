﻿using System;


namespace VerticalFlight.Core.Domain
{
    class OtherInformation
    {
        public virtual int OtherInformationID { get; set; }
        public virtual int ApplicationID { get; set; }
        public virtual string Accolades { get; set; }
        public virtual string ActivitiesHobbies { get; set; }
        public virtual string AviationInvolvement { get; set; }
        public virtual string Achievements { get; set; }
        public virtual string WhyInterested { get; set; }
        public virtual string FlyingExperience { get; set; }
        public virtual string ScholarshipIntent { get; set; }
       
    }
}
