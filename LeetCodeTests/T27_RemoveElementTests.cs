using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T27_RemoveElementTests
    {
        [TestMethod()]
        [DataRow(new int[] {3,2,2,3}, 3)]
        public void RemoveElementTest(int[] nums, int val)
        {
            T27_RemoveElement.RemoveElement(nums, val);
        }
    }
}