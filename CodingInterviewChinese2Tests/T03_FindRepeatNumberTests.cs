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
        /// <summary>
        /// 十进制数字向二进制，八进制，十六进制字符串的转换，使用函数
        /// Convert.ToString(int value, int toBase):
        /// 
        /// 把二进制，八进制，十六进制字符串向十进制数字的转换，使用函数
        /// Convert.ToInt32(string value, int fromBase)：
        /// </summary>
        [TestMethod()]
        public void ConvertNumber()
        {
            


            //十进制转二进制
            var ans1 = Convert.ToString(4, 2);

            //十六进制转二进制
            var ans2 = Convert.ToString(0X41, 2);

            //十六进制转十进制
            var ans3_1 = Convert.ToString(0x41, 10);
            var ans3_2 = Convert.ToInt32("0x41", 16);
            var ans3_3 = int.Parse("41", System.Globalization.NumberStyles.HexNumber);

            //二进制转十进制
            var ans4 = Convert.ToInt32("1010", 2);

            //十进制转十六进制
            var ans5 = 10.ToString("X");

            //二进制转十六进制
            var ans6 = Convert.ToInt32("1010", 2).ToString("X");
        }

        [TestMethod()]
        [DataRow(new int[] { 2, 3, 1, 0, 2, 5, 3 }, new int[] {2, 3})]
        public void FindRepeatNumber1Test(int[] input, int[] expected)
        {
            var a = input.ToList();
            var b = input.ToList();
            a.Sort();
            b.Sort((x, y) => y - x);

            int[][] temp =
            {
                new int[]{ 1, 2, 3, 4 },
                new int[]{ 5,6,7,8},
                new int[]{ 9, 10, 11, 12 }
            };
            int m = temp.Length;
            int n = temp[0].Length;

            int[][] array1 =
                    {
                        new int[] { 1, 3, 5, 7, 9 },
                        new int[] { 0, 2, 4, 6 },
                        new int[] { 11, 22 }
                    };
            int m1 = array1.Length;
            int n1 = array1[0].Length;

            int[,] array2 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            int r2 = array2.Length;
            int rank = array2.Rank;
            int m2 = array2.GetLength(0);
            int n2 = array2.GetLength(1);

            //var r = T03_FindRepeatNumber.FindRepeatNumber1(input);
            //var actual = expected.Any(i => i == r);
            //Assert.IsTrue(actual);
        }
    }
}