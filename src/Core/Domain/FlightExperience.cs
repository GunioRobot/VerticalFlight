using System;


namespace VerticalFlight.Core.Domain
{
    public class FlightExperience
    {
        public virtual int FlightExperienceID { get; set; }
        public virtual int ApplicationID { get; set; }
        public virtual string MakeModel { get; set; }
        public virtual string Turbine { get; set; }
        public virtual string Reciprocating { get; set; }
        public virtual string CrossCountry { get; set; }
        public virtual string HeliHoursTotalPIC { get; set; }
        public virtual string HeliHours6mo { get; set; }
        public virtual string HeliHours5Years { get; set; }
        public virtual string AirTotalPIC { get; set; }
        public virtual string AirHours6mo { get; set; }
        public virtual string AirHours5Years { get; set; }
        public virtual string Total { get; set; }
    }

}