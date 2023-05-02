using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class tstActivitiesColection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsActivitiesCollection AllActivities = new clsActivitiesCollection();
            //test to see that it exists
            Assert.IsNotNull(AllActivities);
        }
    }
}
