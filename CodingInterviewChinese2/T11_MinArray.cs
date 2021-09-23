using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T11_MinArray
    {
        public int MinArray(int[] numbers)
        {
            int startIndex = 0;
            int endIndex = numbers.Length - 1;
            int mid = startIndex;
            var temp = numbers[mid];

            while (numbers[startIndex] >= numbers[endIndex])
            {
                if (endIndex - startIndex == 1)
                {
                    mid = endIndex;
                    temp = numbers[mid];
                    break;
                }

                mid = (startIndex + endIndex) >> 1;
                temp = numbers[mid];

                if (temp == numbers[startIndex] && temp == numbers[endIndex])
                {
                    temp = numbers.Min();
                    break;
                }

                if (temp <= numbers[endIndex])
                    endIndex = mid;
                else if (temp >= numbers[startIndex])
                    startIndex = mid;
            }
            return temp;
        }
    }
}
