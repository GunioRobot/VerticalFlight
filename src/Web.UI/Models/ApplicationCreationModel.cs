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
        [DisplayName("Current Employer")]
        public string EmploymentInfoCurrentEmployer { get; set; }
        
        [DisplayName("Address")]
        public string EmploymentInfoEmployerAddress { get; set; }
        
        [DisplayName("Phone")]
        public string EmploymentInfoPhone { get; set; }
        
        [DisplayName("Fax")]
        public string EmploymentInfoFax { get; set; }
        
        [DisplayName("Email")]
        public string EmploymentInfoEmail { get; set; }
        
        [DisplayName("Title")]
        public string EmploymentInfoCurrentPositionTitle { get; set; }
        
        
        [DisplayName("Applicant Name")]
        public string EmploymentInfoEmploymentDates { get; set; }
        
        [DisplayName("Applicant Name")]
        public string EmploymentInfoManagerName { get; set; }
        
        [DisplayName("Applicant Name")]
        public string EmploymentInfoManagerPhone { get; set; }
        
        [DisplayName("Applicant Name")]
        public string EmploymentInfoCurrentReasonForLeaving { get; set; }
        
        [DisplayName("Applicant Name")]
        public string EmploymentInfoCurrentSalary { get; set; }
        
        [DisplayName("Applicant Name")]
        public string EmploymentInfoCurrentJobDuties { get; set; }
        
        [DisplayName("Applicant Name")]
        public string EmploymentInfoPriorEmployer { get; set; }
        
        [DisplayName("Applicant Name")]
        public string EmploymentInfoPriorSalary { get; set; }
        
        [DisplayName("Applicant Name")]
        public string EmploymentInfoPriorJobDuties { get; set; }
        
        [DisplayName("Applicant Name")]
        public string EmploymentInfoPriorPositionTitle { get; set; }
        
        [DisplayName("Applicant Name")]
        public string EmploymentInfoPriorReasonForLeaving { get; set; }

        [DisplayName("Applicant Name")]
        public string EmploymentInfoPriorEmploymentDates { get; set; }

        public IList<FlightExperience> FlightExperience { get; set; }


    }
}