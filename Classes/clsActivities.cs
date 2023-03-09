using System;

namespace Classes
{
    public class clsActivities
    {
        public clsActivities()
        {
        }

        public bool Active { get; set; }
        public string ActivityCity { get; set; }
        public string ActivityDescription { get; set; }
        public string ActivityName { get; set; }
        public string ActivityPostCode { get; set; }
        public decimal ActivityPrice { get; set; }

        public bool Find(int activityID)
        {
            return true;
        }
    }
}