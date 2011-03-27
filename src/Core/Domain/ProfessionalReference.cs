using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VerticalFlight.Core.Domain
{
    public class ProfessionalReference
    {
        public virtual int ProfessionalReferenceID { get; set; }
        public virtual Application Application { get; set; }
        public virtual string Name { get; set; }
        public virtual string Title { get; set; }
        public virtual string Organization { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Zip { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Relationship { get; set; }
        public virtual string LengthOfTime { get; set; }

    }


}
