using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Software_2_MS;

namespace UNT
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            string username = "username";
            string password = "password";
            int Actual = Data.userCheck(username,password);
            int Expected = 1;
            Assert.AreNotEqual(Expected, Actual, "test failed username and password are incorrect.");
        }

        [TestMethod]
        public void TestMethod2()
        {

        }

        [TestMethod]
        public void TestMethod3()
        {

        }

        [TestMethod]
        public void TestMethod4()
        {

        }
    }
}
