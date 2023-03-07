using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class tstRoom
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance
            clsRoom ARoom = new clsRoom();
            Assert.IsNotNull(ARoom);
        }
    }
}
