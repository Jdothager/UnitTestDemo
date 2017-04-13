using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobs.Data;

namespace UnitTestDemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void JobData_JobAreNotNull()
        {
            JobData jobData = new JobData();
            var jobs = jobData.Jobs;

            Assert.IsNotNull(jobs);
        }

        [TestMethod]
        public void JobData_FindByValue_ContainsNewYork()
        {
            JobData jobData = new JobData();
            var jobs = jobData.FindByValue("New York");

            Assert.AreEqual(1, jobs.Count);
        }
    }
}
