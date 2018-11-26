using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsoleAppExperiments;

namespace TestConsoleUnitTests
{
    [TestClass]
    public class Unit_Tests_For_DegreeBetweenHourandMinute
    {

        [DataTestMethod]
        [DataRow(12, 30, 165.0)]
        [DataRow(12, 0, 0.0)]
        [DataRow(6, 30, 15.0)]
        [DataRow(12, 0, 0.00)]
        [DataRow(12, 59, 144.5)]
        public void DegreeBetweenHourandMinute_Returns_Correctly(int hour, int minute, double expected)
        {
            double result = ConsolePlayground.DegreeBetweenHourandMinute(hour, minute);

            Assert.AreEqual(expected, result);
        }
    }
}
