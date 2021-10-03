using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T12_Exist
    {
        public bool Exist(char[][] board, string word)
        {
            if (board == null)
                return false;
            var m = board.Length;
            if (m == 0)
                return false;
            var n = board[0].Length;

            bool[][] isSelect = new bool[m][];
            for (int i = 0; i < m; i++)
            {
                isSelect[i] = new bool[n];
            }

            int currIndex = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (HasWord(board, m, n, i, j, word, currIndex, isSelect))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        bool HasWord(char[][] board, int rows, int cols, int r, int c, string word, int currIndex, bool[][] isSelect)
        {
            if (r < 0 || r >= rows || c < 0 || c >= cols)
                return false;

            if(!isSelect[r][c] && board[r][c] == word[currIndex])
            {
                isSelect[r][c] = true;
                currIndex++;
            }
            else
            {
                return false;
            }

            if (currIndex == word.Length)
                return true;

             var ans = HasWord(board, rows, cols, r, c - 1, word, currIndex, isSelect)
                || HasWord(board, rows, cols, r, c + 1, word, currIndex, isSelect)
                || HasWord(board, rows, cols, r - 1, c, word, currIndex, isSelect)
                || HasWord(board, rows, cols, r + 1, c, word, currIndex, isSelect);

            if (ans == false)
            {
                currIndex--;
                isSelect[r][c] = false;
            }
            return ans;
        }
    }
}
