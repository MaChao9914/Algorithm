using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T64_SumNums
    {
        public int SumNums(int n)
        {
            //if (n == 1)
            //    return n;
            //return n + SumNums(n - 1);

            bool isRecur = n >= 1 && (n += SumNums(n - 1)) >= 1;
            return n;


        }
    }
}
