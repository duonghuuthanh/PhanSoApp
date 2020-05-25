using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhanSo;

namespace PhanSoTester
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void init()
        { 
            // mo ket noi
        }

        [TestCleanup]
        public void teardown()
        {
             // dong ket noi
        }

        [TestMethod]
        public void TestEquals()
        {
            PhanSo.PhanSo p1 = new PhanSo.PhanSo(2, 3);
            PhanSo.PhanSo p2 = new PhanSo.PhanSo(-4, -6);
            bool actual = PhanSo.PhanSo.soSanh(p1, p2);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod1()
        {
            PhanSo.PhanSo p1 = new PhanSo.PhanSo(2, 3);
            PhanSo.PhanSo p2 = new PhanSo.PhanSo(4, -6);
            bool actual = PhanSo.PhanSo.soSanh(p1, p2);
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestException()
        {
            new PhanSo.PhanSo(2, 0);
        }

        private TestContext testContext;

        public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data.csv", "Data#csv", DataAccessMethod.Sequential), DeploymentItem("..\\PhanSoTester\\Data.csv"), TestMethod]
        public void TestFile()
        {
            int t1 = int.Parse(TestContext.DataRow[0].ToString());
            int m1 = int.Parse(TestContext.DataRow[1].ToString());
            int t2 = int.Parse(TestContext.DataRow[2].ToString());
            int m2 = int.Parse(TestContext.DataRow[3].ToString());
            bool expected = bool.Parse(TestContext.DataRow[4].ToString());

            PhanSo.PhanSo p1 = new PhanSo.PhanSo(t1, m1);
            PhanSo.PhanSo p2 = new PhanSo.PhanSo(t2, m2);
            bool actual = PhanSo.PhanSo.soSanh(p1, p2);

            Assert.AreEqual(expected, actual);
        }
    }
}
