using System;
using Olympiad_Grading.AvaComm;
using Olympiad_Grading.AvaComm.Poco;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradingUnitTest
{
    [TestClass]
    public class JsonRequestTest
    {
        string BinUrl = "http://requestb.in/1dr5qqe1";

        [TestMethod]
        public void TestGetWithApiAuth()
        {
            JsonRequest request = new JsonRequest(BinUrl, "GET", new ApiAuth("IT's a super good key!"));

            request.Execute();
        }

        [TestMethod]
        public void TestPostWithObject()
        {
            JsonRequest request = new JsonRequest(BinUrl, "POST", new ApiAuth("IT's a super good key!"));

            object x = new object();

            x = new { firstName = "john", lastName = "walter" };

            request.Execute(x);
        }

        [TestMethod]
        public void TestPostWithObjectList()
        {
            JsonRequest request = new JsonRequest(BinUrl, "POST", new ApiAuth("IT's a super good key!"));

            object[] x = new object[2];

            x[0] = new { firstName = "john", lastName = "walter" };
            x[1] = new { brand = "BMW" };

            request.Execute(x);
        }


    }
}
