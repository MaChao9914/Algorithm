using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T96_UniqueBinarySearchTreesTests
    {
        [TestMethod()]
        [DataRow(3,5,DisplayName ="test1")]
        public void NumTreesTest(int n, int expected)
        {
            T96_UniqueBinarySearchTrees t96_UniqueBinary = new T96_UniqueBinarySearchTrees();
            var actual = t96_UniqueBinary.NumTrees1(n);
            Assert.AreEqual(expected, actual);
        }
    }
}