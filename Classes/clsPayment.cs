using System;

namespace Classes
{
    public class clsPayment
    {
        public int PaymentID { get; set; }
        public int CustomerID { get; set; }
        public int PaymentAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentType { get; set; }
    }
}