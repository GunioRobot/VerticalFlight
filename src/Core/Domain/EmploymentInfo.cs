namespace VerticalFlight.Core.Domain
{
    public class EmploymentInfo
    {
        public virtual int EmploymentInfoID { get; set; }
        public virtual Application Application { get; set; }
        public virtual string CurrentEmployer { get; set; }
        public virtual string EmployerAddress { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Fax { get; set; }
        public virtual string Email { get; set; }
        public virtual string CurrentPositionTitle { get; set; }
        public virtual string EmploymentDates { get; set; }
        public virtual string ManagerName { get; set; }
        public virtual string ManagerPhone { get; set; }
        public virtual string CurrentReasonForLeaving { get; set; }
        public virtual string CurrentSalary { get; set; }
        public virtual string CurrentJobDuties { get; set; }
        public virtual string PriorEmployer { get; set; }
        public virtual string PriorSalary { get; set; }
        public virtual string PriorJobDuties { get; set; }
        public virtual string PriorPositionTitle { get; set; }
        public virtual string PriorReasonForLeaving { get; set; }
        public virtual string PriorEmploymentDates { get; set; }
    }
}