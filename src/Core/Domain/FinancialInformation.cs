using System;

namespace VerticalFlight.Core.Domain
{
    public class FinancialInformation
    {
        public virtual int FinancialInformationID { get; set; }
        public virtual int ApplicationID { get; set; }
        public virtual string Need { get; set; }
        public virtual string DiscountAccess { get; set; }
        public virtual string AnnualIncome { get; set; }
        public virtual string IncomeSource { get; set; }
        public virtual string AssetsAndValue { get; set; }
        public virtual string Liabilities { get; set; }
        public virtual string DependentDetails { get; set; }

    }
}
