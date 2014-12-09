using System;
using Olympiad_Grading.AvaComm;
using Olympiad_Grading.AvaComm.Poco;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradingUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            JsonRequest request = new JsonRequest("http://requestb.in/oq1h9soq", "GET", new ApiAuth("IT's a super good key!"));

            request.Execute();
        }
    }
}
