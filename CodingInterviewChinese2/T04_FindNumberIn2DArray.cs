using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T04_FindNumberIn2DArray
    {
        public bool FindNumberIn2DArray(int[][] matrix, int target)
        {
            int rows = matrix.Length;
            if (rows == 0)
                return false;
            int columns = matrix[0].Length;
            if (columns == 0)
                return false;
            
            if (matrix[rows - 1][columns - 1] < target)
                return false;

            int i = 0;
            int j = columns - 1;
            while (i < rows && j >= 0)
            {
                var temp = matrix[i][j];
                if (temp == target)
                    return true;
                else if (target < temp)
                    j--;
                else if (target > temp)
                    i++;
            }
            return false;
        }
    }
}
