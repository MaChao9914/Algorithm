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
    public class MyCalendarTests
    {
        [TestMethod()]
        public void BookTest()
        {
            MyCalendar obj = new MyCalendar();
            bool param_1 = obj.Book(10, 20);
            param_1 = obj.Book(15, 25);
        }
    }
}