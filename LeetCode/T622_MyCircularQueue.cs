using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MyCircularQueue
    {
        private int[] _queue;
        private int _headIndex = 0, _count = 0, _capacity = 0;
        public MyCircularQueue(int k)
        {
            _queue = new int[k];
            _capacity = k;
        }

        public bool EnQueue(int value)
        {
            if (IsFull())
                return false;
            _queue[(this._headIndex + this._count) % this._capacity] = value;
            this._count++;
            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty())
                return false;
            this._headIndex = (this._headIndex + 1) % _capacity;
            this._count--;
            return true;
        }

        public int Front()
        {
            if (IsEmpty())
                return -1;
            return this._queue[_headIndex];
        }

        public int Rear()
        {
            if (IsEmpty())
                return -1;
            return this._queue[(_headIndex + _count - 1) % _capacity];
        }

        public bool IsEmpty()
        {
            return this._count == 0;
        }

        public bool IsFull()
        {
            return this._capacity == this._count;
        }
    }
}
