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
    public class T30_MinStackTests
    {
        [TestMethod()]
        public void T30_MinStackTest()
        {
            T30_MinStack minStack = new T30_MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);

            int? minData = minStack.Min();
            Assert.AreEqual(-3, minData);

            minStack.Pop();
            int? top = minStack.Top();
            Assert.AreEqual(0, top);

            minData = minStack.Min();
            Assert.AreEqual(-2, minData);
        }
    }
}