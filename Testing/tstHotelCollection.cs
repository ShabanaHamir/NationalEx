using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class tstHotelCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //instance of the class I want to create
            clsHotelCollection AllHotels = new clsHotelCollection();
            Assert.IsNotNull(AllHotels);
        }
        [TestMethod]
        public void HotelListOK()
        { 

        }

    }
}
