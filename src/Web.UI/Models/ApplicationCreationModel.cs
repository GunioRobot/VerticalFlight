using System;
using System.Collections.Generic;
using VerticalFlight.Core.Domain;

namespace Web.UI.Models
{
    public class ApplicationCreationModel
    {
        public int ScholarshipID { get; set; }
        public virtual int UserID { get; set; }
        
        /* Application Information */
        public string ApplicationInformationApplicantName { get; set; }
        public DateTime ApplicationInformationDOB { get; set; }
        public string ApplicationInformationCitizenship { get; set; }
        public string ApplicationInformationAddress { get; set; }
        public string ApplicationInformationCity { get; set; }
        public string ApplicationInformationState { get; set; }
        public string ApplicationInformationZip { get; set; }
        public string ApplicationInformationHomePhone { get; set; }
        public string ApplicationInformationMobilePhone { get; set; }

        /* Employment Info */
        public string EmploymentInfoCurrentEmployer { get; set; }
        public string EmploymentInfoEmployerAddress { get; set; }
        public string EmploymentInfoPhone { get; set; }
        public string EmploymentInfoFax { get; set; }
        public string EmploymentInfoEmail { get; set; }
        public string EmploymentInfoCurrentPositionTitle { get; set; }
        public string EmploymentInfoCurrentEmployerFrom { get; set; }
        public string EmploymentInfoCurrentEmployerTo { get; set; }
        public string EmploymentInfoEmploymentDates { get; set; }
        public string EmploymentInfoManagerName { get; set; }
        public string EmploymentInfoManagerPhone { get; set; }
        public string EmploymentInfoCurrentReasonForLeaving { get; set; }
        public string EmploymentInfoCurrentSalary { get; set; }
        public string EmploymentInfoCurrentJobDuties { get; set; }
        public string EmploymentInfoPriorEmployer { get; set; }
        public string EmploymentInfoPriorSalary { get; set; }
        public string EmploymentInfoPriorJobDuties { get; set; }
        public string EmploymentInfoPriorPositionTitle { get; set; }
        public string EmploymentInfoPriorReasonForLeaving { get; set; }

        public IList<FlightExperience> FlightExperience { get; set; }


    }
}