using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsoleAppExperiments;

namespace TestConsoleUnitTests
{
    [TestClass]
    public class Unit_Tests_For_SecondLargestNum
    {

        [DataTestMethod]
        [DataRow(67, 1, 3, 5, 4, 254, 67, 42)]
        [DataRow(87, 654, 2, 76, 12, 86, 12, 87)]
        [DataRow(8765, -1, 1243, -36, 8765, -8765, 12345, -64)]
        public void SecondLargestNum_Returns_Correctly(int result, int arr1, int arr2, int arr3, int arr4, int arr5, int arr6, int arr7)
        {
            int[] testInput = new int[] { arr1, arr2, arr3, arr4, arr5, arr6, arr7 };

            Assert.AreEqual(result, Program.SecondLargestNum(testInput));
        }
    }
}
