using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace CalculatorTester
{
    [TestClass]
    public class BaiTapPower_Test
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @".\Data\TestData_Power.csv", "TestData_Power#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestBTPowerWithDataSource()
        {
            double x = double.Parse(TestContext.DataRow[0].ToString());
            int n = int.Parse(TestContext.DataRow[1].ToString());
            double expected = double.Parse(TestContext.DataRow[2].ToString());
            double actual = BaiTapPower.Power(x, n);
            Assert.AreEqual(expected, actual);
        }
    }
    
}
