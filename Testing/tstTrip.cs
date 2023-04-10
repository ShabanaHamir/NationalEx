using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class tstTrip
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsTrip AnTrip = new clsTrip();
            //test to see that it exists 
            Assert.IsNotNull(AnTrip);

        }

        [TestMethod]
        public void TripIdPropertyOK()
        {
            //create an instance of the class we want to create 
            clsTrip AnTrip = new clsTrip();
        //create some test data to assign to the property 
        Int32 TestData = 4;
            //assign data to the property 
            AnTrip.TripId = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnTrip.TripId, TestData);

        }

    }

    class clsTrip
    {
        public clsTrip()
        {
        }
    }
}
