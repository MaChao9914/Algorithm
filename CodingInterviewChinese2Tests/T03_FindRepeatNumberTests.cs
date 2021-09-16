using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingInterviewChinese2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2.Tests
{
    [TestClass()]
    public class T03_FindRepeatNumberTests
    {
        [TestMethod()]
        [DataRow(new int[] { 2, 3, 1, 0, 2, 5, 3 }, new int[] {2, 3})]
        public void FindRepeatNumber1Test(int[] input, int[] expected)
        {
            var r = T03_FindRepeatNumber.FindRepeatNumber1(input);

            var actual = expected.Any(i => i == r);
            Assert.IsTrue(actual);
        }
    }
}