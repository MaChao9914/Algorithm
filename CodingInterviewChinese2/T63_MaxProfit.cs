using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T63_MaxProfit
    {
        public int MaxProfit(int[] prices)
        {
            int length = prices.Length;
            if (length <= 1)
                return 0;
            int min = prices[0];
            int maxDif = prices[1] - min;

            for (int i = 2; i < length; i++)
            {
                if (prices[i - 1] < min)
                    min = prices[i - 1];

                int temp = prices[i] - min;
                if (temp > maxDif)
                    maxDif = temp;
            }

            return maxDif <= 0 ? 0 : maxDif;
        }
    }
}
