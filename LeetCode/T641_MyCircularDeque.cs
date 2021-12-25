using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// 双端循环队列
    /// 622题循环队列
    /// </summary>
    public class MyCircularDeque
    {
        private int[] _queue;
        private int _headIndex = 0, _capacity = 0, _count = 0;
        public MyCircularDeque(int k)
        {
            _queue = new int[k];
            _capacity = k;
        }

        public bool InsertFront(int value)
        {
            if (IsFull())
                return false;
            _headIndex = (_headIndex + _capacity - 1) % _capacity;
            _queue[_headIndex] = value;
            this._count++;
            return true;
        }

        public bool InsertLast(int value)
        {
            if (IsFull())
                return false;
            _queue[(_headIndex + _count) % _capacity] = value;
            this._count++;
            return true;
        }

        public bool DeleteFront()
        {
            if (IsEmpty())
                return false;
            _headIndex = (_headIndex + 1) % _capacity;
            _count--;
            return true;
        }

        public bool DeleteLast()
        {
            if (IsEmpty())
                return false;
            _count--;
            return true;
        }

        public int GetFront()
        {
            if (IsEmpty())
                return -1;
            return _queue[_headIndex];
        }

        public int GetRear()
        {
            if (IsEmpty())
                return -1;
            return _queue[(_headIndex + _count - 1) % _capacity];
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public bool IsFull()
        {
            return _count == _capacity;
        }
    }
}
