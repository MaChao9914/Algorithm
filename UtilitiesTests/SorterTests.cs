using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Tests
{
    [TestClass()]
    public class SorterTests
    {
        [TestMethod()]
        [DataRow(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 8 })]
        public void QuickSortTest(int[] input, int[] output)
        {
            var result = Sorter.QuickSort<int>(input, 0, input.Length - 1);
            var isEqual = result.SequenceEqual(output);
            Assert.AreEqual(isEqual, true);
        }

        [TestMethod()]
        [DataRow(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 8 })]
        public void BubbleSortTest(int[] input, int[] output)
        {
            var result = Sorter.BubbleSort<int>(input);
            var isEqual = result.SequenceEqual(output);
            Assert.IsTrue(isEqual);
        }

        [TestMethod()]
        [DataRow(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 8 })]
        public void MergeSortTest(int[] input, int[] output)
        {
            var result = Sorter.MergeSort<int>(input, 0, input.Length - 1);
            var isEqual = result.SequenceEqual(output);

            //bool isEqual = test(0) || test(1) && test(2);

            Assert.IsTrue(isEqual);
        }

        bool test(int a)
        {
            int b = a;
            Console.WriteLine(b);
            return a >= 1 ? true : false;
        }

        [TestMethod()]
        [DataRow(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 8 })]
        public void InsertionSortTest(int[] input, int[] output)
        {
            var result = Sorter.InsertionSort<int>(input);
            var isEqual = result.SequenceEqual(output);
            Assert.IsTrue(isEqual);
        }
    }
}