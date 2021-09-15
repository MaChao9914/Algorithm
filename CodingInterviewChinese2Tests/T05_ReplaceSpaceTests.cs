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
    public class T05_ReplaceSpaceTests
    {
        [TestMethod()]
        [DataRow("We are happy.", "We%20are%20happy.")]
        public void ReplaceSpaceTest(string input, string output)
        {
            var r = T05_ReplaceSpace.ReplaceSpace(input);
            Assert.AreEqual(output, r);
        }
    }
}