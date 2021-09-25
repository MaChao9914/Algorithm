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
            int[][] array1 =
                    {
                        new int[] { 1, 3, 5, 7, 9 },
                        new int[] { 0, 2, 4, 6 },
                        new int[] { 11, 22 }
                    };
            int r1 = array1.Length;
            int c1 = array1[0].Length;

            int[,] array2 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            int r2 = array2.Length;
            int rank = array2.Rank;
            r2 = array2.GetLength(0);
            r2 = array2.GetLength(1);

            //var r = T03_FindRepeatNumber.FindRepeatNumber1(input);

            //var actual = expected.Any(i => i == r);
            //Assert.IsTrue(actual);
        }
    }
}