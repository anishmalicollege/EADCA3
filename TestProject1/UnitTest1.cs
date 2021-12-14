using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EADCA3;

namespace TestProject1.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void Test1()
        {
            Root r1 = new Root();
            r1.results[0].title = "Game of Thrones";
            string expected = "Game of Thrones";
            string actualResult = r1.results[0].title;
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod()]
        public void Test2()
        {
            Root r1 = new Root();
            r1.results[0].title = "Lost";
            string expected = "Lost";
            string actualResult = r1.results[0].title;
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod()]
        public void Test3()
        {
            Root r1 = new Root();
            r1.results[0].year = 2004;
            int expected = 2004;
            int actualResult = r1.results[0].year;
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod()]
        public void Test4()
        {
            Root r1 = new Root();
            r1.results[0].year = 2020;
            int expected = 2020;
            int actualResult = r1.results[0].year;
            Assert.AreEqual(expected, actualResult);
        }
    }
}

