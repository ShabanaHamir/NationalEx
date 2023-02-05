using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class tstActivities
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsActivities AnActivity = new clsActivities();
            Assert.IsNotNull(AnActivity);
        }
    }
}
