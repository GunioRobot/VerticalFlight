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
        
        [DisplayName("Position Title")]
        public string EmploymentInfoCurrentPositionTitle { get; set; }
                
        [DisplayName("Dates Employed")]
        public string EmploymentInfoEmploymentDates { get; set; }
        
        [DisplayName("Manager Name")]
        public string EmploymentInfoManagerName { get; set; }
        
        [DisplayName("Manager Phone")]
        public string EmploymentInfoManagerPhone { get; set; }
        
        [DisplayName("Salary")]
        public string EmploymentInfoCurrentSalary { get; set; }
        
        [DisplayName("Job Duties")]
        public string EmploymentInfoCurrentJobDuties { get; set; }
        
        [DisplayName("Prior Employer")]
        public string EmploymentInfoPriorEmployer { get; set; }
        
        [DisplayName("Salary")]
        public string EmploymentInfoPriorSalary { get; set; }
        
        [DisplayName("Job Duties")]
        public string EmploymentInfoPriorJobDuties { get; set; }
        
        [DisplayName("Position Title")]
        public string EmploymentInfoPriorPositionTitle { get; set; }
        
        [DisplayName("Reason For Leaving")]
        public string EmploymentInfoPriorReasonForLeaving { get; set; }

        [DisplayName("Dates Employed")]
        public string EmploymentInfoPriorEmploymentDates { get; set; }

        public IList<EducationTraining> EducationTraining { get; set; }
        public IList<AirmanCertificate> AirmanCertificates { get; set; }
        public IList<FlightExperience> FlightExperience { get; set; }
        public IList<ProfessionalReference> ProfessionalReferences { get; set; }

        [DisplayName("Honors/awards/scholarships you have received")]
        public string OtherInformationAccolades { get; set; }

        [DisplayName("Organization affiliations")]
        public string OtherInformationAffiliations { get; set; }
        
        [DisplayName("Activities/Hobbies")]
        public string OtherInformationActivitiesHobbies { get; set; }
                
        [DisplayName("Involvement in aviation-related activities")]
        public string OtherInformationAviationInvolvement { get; set; }

        [DisplayName("Aviation achievements or contributions you have made to the industry")]
        public string OtherInformationAchievements { get; set; }

        [DisplayName("What made you interested in becoming a helicopter pilot?")]
        public string OtherInformationWhyInterested { get; set; }

        [DisplayName("What is your flying experience? Tell us your story.")]
        public string OtherInformationFlyingExperience { get; set; }

        [DisplayName("How do you intend to use this scholarship to further your aviation goals? Please include what your short term & long term goals are and why you consider this scholarship to be beneficial to those goals. Please be in-depth with your answer.")]
        public string OtherInformationScholarshipIntent { get; set; }



        [DisplayName("Why do you need this financial assistance? (Please be specific)")]
        public string FinancialInformationNeed { get; set; }

        [DisplayName("Do you have access to discounted or free use of helicopter instruction and/or flight time? If yes, please explain.")]
        public string FinancialInformationDiscountAccess { get; set; }

        [DisplayName("Total Annual Household Income: (If you are head of Household please list family structure)")]
        public string FinancialInformationAnnualIncome { get; set; }

        [DisplayName("Sources of Income: (Please list source and associated annual amounts)")]
        public string FinancialInformationIncomeSource { get; set; }

        [DisplayName("List all assets and estimated value:")]
        public string FinancialInformationAssetsAndValue { get; set; }

        [DisplayName("List all liabilities and amount of each:")]
        public string FinancialInformationLiabilities { get; set; }

        [DisplayName("Are you listed as a dependent on anyone’s income tax return? If yes, please explain.")]
        public string FinancialInformationDependentDetails { get; set; }
    }
}