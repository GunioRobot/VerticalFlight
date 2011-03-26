using System;


namespace VerticalFlight.Core.Domain
{
    public class ScholarshipInfo
    {
        public virtual int ScholarshipInfoID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string DocPath { get; set; }
        public virtual DateTime OpenDate { get; set; }
        public virtual DateTime CloseDate { get; set; }
    }
}