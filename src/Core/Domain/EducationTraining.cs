using System;


namespace VerticalFlight.Core.Domain
{
    public class EducationTraining
    {
        public virtual int EducationTrainingID { get; set; }
        public virtual Application Application { get; set; }
        public virtual string Institution { get; set; }
        public virtual DateTime AttendedFrom { get; set; }
        public virtual DateTime AttendedTo { get; set; }
        public virtual string DetailedStudies { get; set; }

    }
}
