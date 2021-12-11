using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FreqStack
    {
        int _maxFreq;
        Dictionary<int, int> _freqDic;
        Dictionary<int, Stack<int>> _pairs;
        public FreqStack()
        {
            _maxFreq = 0;
            _freqDic = new Dictionary<int, int>();
            _pairs = new Dictionary<int, Stack<int>>();
        }

        public void Push(int val)
        {
            int _freq = 0;
            if (_freqDic.TryGetValue(val, out _freq))
            {
                _freq += 1;
                _freqDic[val] = _freq;
            }
            else
            {
                _freq += 1;
                _freqDic.Add(val, _freq);
            }

            if (_freq > _maxFreq)
                _maxFreq = _freq;

            if (_pairs.ContainsKey(_freq))
                _pairs[_freq].Push(val);
            else
            {
                Stack<int> stack = new Stack<int>();
                stack.Push(val);
                _pairs.Add(_freq, stack);
            }
        }

        public int Pop()
        {
            int ans = _pairs[_maxFreq].Pop();
            _freqDic[ans] -= 1;

            if (_pairs[_maxFreq].Count == 0)
                _maxFreq -= 1;

            return ans;
        }
    }

    /**
     * Your FreqStack object will be instantiated and called as such:
     * FreqStack obj = new FreqStack();
     * obj.Push(val);
     * int param_2 = obj.Pop();
     */
}
