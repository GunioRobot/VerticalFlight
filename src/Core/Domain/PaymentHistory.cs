using System;


namespace VerticalFlight.Core.Domain
{
    public class PaymentHistory
    {
        public virtual int PaymentHistoryID { get; set; }
        public virtual int ApplicationID { get; set; }
        public virtual DateTime TransactionDate { get; set; }
        public virtual string TransactionResultID { get; set; }
        public virtual string TransactionResult { get; set; }
        public virtual string TransactionVendor { get; set; }
        public virtual float TransactionAmount { get; set; }
    }
}
