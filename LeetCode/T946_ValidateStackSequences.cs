using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class T946_ValidateStackSequences
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            Stack<int> stack = new Stack<int>();
            int i = 0;
            foreach (var item in pushed)
            {
                stack.Push(item);
                while (stack.Count != 0 && stack.Peek() == popped[i])
                {
                    stack.Pop();
                    i++;
                }
            }
            return stack.Count == 0;
        }
    }
}
