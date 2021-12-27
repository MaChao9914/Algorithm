using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class T1047_RemoveDuplicates
    {
        public string RemoveDuplicates(string s)
        {
            Stack<char> newStr = new Stack<char>();
            int length = s.Length;
            for (int i = 0; i < length; i++)
            {
                var ch = s[i];
                if (newStr.Count == 0)
                {
                    newStr.Push(ch);
                }
                else
                {
                    if (newStr.Peek() == ch)
                    {
                        newStr.Pop();
                    }
                    else
                    {
                        newStr.Push(ch);
                    }
                }
            }

            return new string(newStr.Reverse().ToArray());
        }
    }
}
