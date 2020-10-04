using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests
{
    [TestClass()]
    public class T17_LetterCombinationsofaPhoneNumberTests
    {
        [TestMethod()]
        [DataRow("234")]
        public void LetterCombinationsTest(string digits)
        {
            T17_LetterCombinationsofaPhoneNumber t17_Letter = new T17_LetterCombinationsofaPhoneNumber();
            var result = t17_Letter.LetterCombinations(digits);
        }
    }
}