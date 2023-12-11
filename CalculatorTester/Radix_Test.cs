using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTester
{
    [TestClass]
    public class Radix_Test
    {
        [TestClass]
        public class RadixUnitTest
        {
            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            //khong hop le cua co so k<2, k>16
            public void TestRadix1()
            {
                int radix = 17, num = 1;
                Radix r = new Radix(num);
                r.ConvertDecimalToAnother(radix);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            //khong hop le cua number<0
            public void TestRadix2()
            {
                int num = -1;
                Radix r = new Radix(num);
            }

            public TestContext TestContext { get; set; }
            [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
    @".\Data\TestData_Radix.csv", "TestData_Radix#csv", DataAccessMethod.Sequential)]
            [TestMethod]
            //truong hop dung
            public void TestRadix3()
            {
                int num = int.Parse(TestContext.DataRow[0].ToString());
                int radix = int.Parse(TestContext.DataRow[1].ToString());
                String expected = TestContext.DataRow[2].ToString();
                Radix r = new Radix(num);
                Assert.AreEqual(expected, r.ConvertDecimalToAnother(radix));
            }
        }
    }
}
