using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T30_MinStack
    {
        private Stack<int> _data;
        private Stack<int> _minData;
        public T30_MinStack()
        {
            _data = new Stack<int>();
            _minData = new Stack<int>();
        }

        public void Push(int x)
        {
            int currentMin = _minData.Count == 0 ? x : _minData.Peek();
            if (currentMin > x)
                currentMin = x;

            _data.Push(x);
            _minData.Push(currentMin);
        }

        public void Pop()
        {
            if (_data.Count != 0 && _minData.Count != 0)
            {
                _data.Pop();
                _minData.Pop();
            }
        }

        public int? Top()
        {
            if (_data.Count == 0)
                return null;
            _minData.Peek();
            return _data.Peek();
        }

        public int? Min()
        {
            if (_data.Count == 0)
                return null;
            return _minData.Peek();
        }
    }
}
