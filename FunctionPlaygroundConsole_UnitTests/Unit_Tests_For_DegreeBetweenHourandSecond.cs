using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsoleAppExperiments;

namespace TestConsoleUnitTests
{
    [TestClass]
    public class Unit_Tests_For_DegreeBetweenHourandSecond
    {

        [DataTestMethod]
        // DataRow([hour], [minute], [second], [expectedValue])
        [DataRow(12, 30, 30, 165.0)]
        [DataRow(12, 0, 45, 90)]
        [DataRow(6, 30, 47, 87)]
        //[DataRow(12, 0, 0.00)]
        //[DataRow(12, 59, 324.5)]
        public void DegreeBetweenHourandSecond_Returns_Correctly(int hour, int minute, int second, double expected)
        {
            double result = ConsolePlayground.DegreeBetweenHourandSecond(hour, minute, second);

            Assert.AreEqual(expected, result);
        }
    }
}
