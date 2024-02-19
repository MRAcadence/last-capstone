using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Software_2_MS;

namespace UNT
{
    [TestClass]
    public class UnitTest1
    {
        // unit test script for the unit test project 
        [TestMethod]
        public void TestUsernamePasword()
        {
            string username = "username";
            string password = "password";
            int Actual = Data.userCheck(username,password);
            int Expected = 1;
            Assert.AreNotEqual(Expected, Actual, "test failed username and password are incorrect.");
        }

        [TestMethod]
        public void TestCheckAppointment()
        {
            string custID = "1";
            bool Actual = Data.checkApp(custID);
            int Expected = 1;
            Assert.AreNotEqual(Expected, Actual, "test failed customer id is incorrect.");
        }

        [TestMethod]
        public void TestAppOverlaps()
        {
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddHours(1);
            bool Actual = Data.appOverlaps(start, end);
            int Expected = 1;
            Assert.AreNotEqual(Expected, Actual, "test failed start and end times are overlapping.");
        }

    }
}
