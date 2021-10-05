using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class MedianFinder
    {
        //List<int> _mins;//存较小的一半
        //List<int> _bigs;//
        List<int> _datas;
        /** initialize your data structure here. */
        public MedianFinder()
        {
            //_mins = new List<int>();
            //_bigs = new List<int>();
            _datas = new List<int>();
        }

        public void AddNum(int num)
        {
            _datas.Add(num);
            _datas.Sort();
            //if (_mins.Count == _bigs.Count)
            //{
            //    //_mins.Add(num);
            //    //_mins.Sort((x, y) => y - x);
            //    //_bigs.Add(_mins[0]);
            //    //_bigs.Sort();
            //    //_mins.RemoveAt(0);
            //    _mins.Add(num);
            //    int m = _mins.Max();
            //    _bigs.Add(m);
            //    _mins.Remove(m);
            //}
            //else
            //{
            //    //_bigs.Add(num);
            //    //_bigs.Sort();
            //    //_mins.Add(_bigs[0]);
            //    //_mins.Sort((x, y) => y - x);
            //    //_bigs.RemoveAt(0);
            //    _bigs.Add(num);
            //    int t = _bigs.Min();
            //    _mins.Add(t);
            //    _bigs.Remove(t);
            //}
        }

        public double FindMedian()
        {
            //return _mins.Count == _bigs.Count ? (_mins.Max() + _bigs.Min()) / 2.0 : _bigs.Min();
            int l = _datas.Count;
            return l % 2 == 0 ? (_datas[l / 2] + _datas[(l - 1) / 2]) / 2.0 : _datas[l / 2];
        }
    }
}
