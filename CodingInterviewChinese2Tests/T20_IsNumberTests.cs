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
    public class T20_IsNumberTests
    {
        [TestMethod()]
        [DataRow(" 0  ", true)]
        public void IsNumber3Test(string s, bool expected)
        {
            T20_IsNumber t20_IsNumber = new T20_IsNumber();
            var r = t20_IsNumber.IsNumber3(s);
            Assert.AreEqual(expected, r);
        }
    }
}