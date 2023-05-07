using System;

namespace Classes
{
    public class clsUser
    {
       
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }
        public string TempPW { get; set; }
        public bool Active { get; set; }
        public bool IsAdmin { get; set; }

        public bool Find(int activityID)
        {
            return true;
        }
    }
}