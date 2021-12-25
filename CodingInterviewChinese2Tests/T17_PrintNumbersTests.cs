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
    public class T17_PrintNumbersTests
    {
        [TestMethod()]
        public void PrintNumbers2Test()
        {
            //char[] num = new char[] { '0', '1', '2', '3' };
            //var s = new string(num);

            T17_PrintNumbers t17_Print = new T17_PrintNumbers();
            t17_Print.PrintNumbers2(2);
        }
    }
}