using System;

namespace Classes
{
    public class clsCustomer
    {
        public string CustomerFName { get; set; }
        public string CustomerLName { get; set; }
        public DateTime CustomerDOB { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPostCode { get; set; }
        public string CustomerEmail { get; set; }
        public int CustomerID { get; set; }

        public bool Find(int customerID)
        {
           return true;
        }
    }
}