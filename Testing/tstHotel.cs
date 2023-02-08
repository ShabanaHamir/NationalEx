using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class tstHotel
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //test to see that it exists
            Assert.IsNotNull(AnHotel);
        }

        class clsHotel
        {
            //
        }



    }
}