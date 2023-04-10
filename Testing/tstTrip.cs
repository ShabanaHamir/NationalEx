using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class tstTrip
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create 
            clsTrip AnTrip = new clsTrip();
            //test to see that it exists 
            Assert.IsNotNull(AnTrip);

        }
    }

    class clsTrip
    {
        public clsTrip()
        {
        }
    }
}
