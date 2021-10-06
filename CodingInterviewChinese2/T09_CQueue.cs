using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T09_CQueue
    {
        private Stack<int> _stack1;
        private Stack<int> _stack2;

        public T09_CQueue()
        {
            _stack1 = new Stack<int>();
            _stack2 = new Stack<int>();
        }

        public void AppendTail(int value)
        {
            _stack1.Push(value);
        }

        public int DeleteHead()
        {
            if (_stack2.Count == 0)
            {
                while (_stack1.Count !=0)
                {
                    _stack2.Push(_stack1.Pop());
                }
            }

            if (_stack2.Count == 0)
            {
                return -1;
            }

            return _stack2.Pop();
        }
    }
}
