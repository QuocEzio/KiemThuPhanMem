using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace CalculatorTester
{
    [TestClass]
    public class DataDrivenCalculation_Test
    {
        public TestContext TestContext { get; set; }
        [TestMethod]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV"
          , @".\Data\TestData_Calculation.csv"
          , "TestData_Calculation#csv"
          , DataAccessMethod.Sequential)]
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());
            Calculation c = new Calculation(a, b);
            int actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @".\Data\TestData_Calculation1.csv", "TestData_Calculation1#csv", DataAccessMethod.Sequential)]
        public void TestWithDataSource2()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            string operation = TestContext.DataRow[2].ToString();
            int expected = int.Parse(TestContext.DataRow[3].ToString());
            //operation.Remove(0, 1);

            Calculation c = new Calculation(a, b);
            int actual = c.Execute(operation);
            Assert.AreEqual(expected, actual);
        }
    }
}

