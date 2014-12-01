using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenSource;

namespace OpenSourceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 test = new Class1();
            Assert.AreEqual(test.test(), 0, "test() not returning correct value");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Class1 test = new Class1();
            Assert.AreEqual(test.test(), 1, "test() not returning correct vlaue");
        }
    }
}
