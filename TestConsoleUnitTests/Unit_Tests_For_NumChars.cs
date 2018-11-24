using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsoleAppExperiments;

namespace TestConsoleUnitTests
{
    [TestClass]
    public class Unit_Tests_For_NumChars
    {

        [DataTestMethod]
        [DataRow("string")]
        [DataRow("op")]
        public void NumChars_Returns_1(string input)
        {
            char[] inputCharArray = input.ToCharArray();
            int result = Program.NumChars(inputCharArray);

            Assert.AreEqual(1, result);
        }

        [DataTestMethod]
        [DataRow("に")]
        public void NumChars_Returns_2(string input)
        {
            char[] inputCharArray = input.ToCharArray();
            int result = Program.NumChars(inputCharArray);

            Assert.AreEqual(2, result);
        }
    }
}
