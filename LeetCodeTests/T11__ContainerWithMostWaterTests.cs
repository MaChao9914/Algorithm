using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T11__ContainerWithMostWaterTests
    {
        [TestMethod()]
        [DataRow(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        public void ContainerTest(int[] height, int expected)
        {
            T11__ContainerWithMostWater t11__ContainerWithMostWater = new T11__ContainerWithMostWater();
            var result = t11__ContainerWithMostWater.MaxContainer(height);

            Assert.AreEqual(expected, result);
        }
    }
}