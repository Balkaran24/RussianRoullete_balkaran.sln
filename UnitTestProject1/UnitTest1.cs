using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianRoullete_Balkaran;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UnitTestCase customLogic = new UnitTestCase();
            var result = customLogic.AddTwoPostiveNumber(10, 20);
            Assert.IsTrue(result == 30);
        }
    }
}
