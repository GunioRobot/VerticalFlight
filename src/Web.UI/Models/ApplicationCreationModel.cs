using System;
using System.Collections.Generic;
using VerticalFlight.Core.Domain;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.UI.Models
{
    public class ApplicationCreationModel
    {
        public int ScholarshipID { get; set; }
        public virtual int UserID { get; set; }
        
        /* Application Information */
        [DisplayName("Applicant Name")]
        [Required(ErrorMessage="* You must enter your name.")]
        public string ApplicationInformationApplicantName { get; set; }

        [DisplayName("Date Of Birth")]
        public DateTime? ApplicationInformationDOB { get; set; }

        [DisplayName("Citizenship")]
        public string ApplicationInformationCitizenship { get; set; }

        [DisplayName("Address")]
        public string ApplicationInformationAddress { get; set; }

        [DisplayName("City")]
        public string ApplicationInformationCity { get; set; }

        [DisplayName("State")]
        public string ApplicationInformationState { get; set; }

        [DisplayName("Zip")]
        public string ApplicationInformationZip { get; set; }

        [DisplayName("Home Phone")]
        public string ApplicationInformationHomePhone { get; set; }

        [DisplayName("Mobile Phone")]
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