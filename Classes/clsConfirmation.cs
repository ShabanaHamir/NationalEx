using System;

namespace Classes
{
    public class clsConfirmation                        //no changes
    {
        public int CustomerID { get; set; }
        public string Email { get; set; }
        public int ConfirmationID { get; set; }

        public Boolean Valid(string Email)
        {
            Boolean OK = true;
            if (Email.Length == 0)
            {
                OK = false;
            }
            return OK;
        }

        public bool Find(int confirmationID)
        {
            return true;
        }
    }
}