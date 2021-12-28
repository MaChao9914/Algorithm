using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T20_IsNumber
    {
        /// <summary>
        /// [+/-][A][.][B][e/E][+/-][A]
        /// 库函数
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsNumber1(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;
            return double.TryParse(s, out double result);
        }

        /// <summary>
        /// 程序员面试经典书本上的解法
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsNumber3(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return false;

            s = s.Trim();
            int index = 0, length = s.Length;

            bool isNum = ScanInteger(s, ref index);

            //出现 . 小数部分
            if(index < length && s[index] == '.')
            {
                index += 1;

                //用或的原因是：1、小数点前面可以没有小数部分 .123
                //2、小数点后面也可以没有数字 123.
                //3、都有数字 123.456
                isNum = ScanUnsignedInteger(s, ref index) || isNum;
            }

            if(index < length && (s[index] == 'e' || s[index] == 'E'))
            {
                index += 1;
                //用且的原因是前后必需有整数，而且后面可以带符号的整数
                isNum = isNum && ScanInteger(s, ref index);
            }

            //字符串以到结尾，中间出现了任何非数字都无法达到结尾
            return isNum && index == length;
        }

        /// <summary>
        /// 扫描整数
        /// </summary>
        /// <param name="s"></param>
        /// <param name="currIndex"></param>
        /// <returns></returns>
        private bool ScanInteger(string s, ref int currIndex)
        {
            if (currIndex < s.Length && (s[currIndex] == '+' || s[currIndex] == '-'))
                currIndex += 1;
            return ScanUnsignedInteger(s, ref currIndex);
        }

        /// <summary>
        /// 扫描无符号整数
        /// </summary>
        /// <param name="s"></param>
        /// <param name="currIndex"></param>
        /// <returns></returns>
        private bool ScanUnsignedInteger(string s, ref int currIndex)
        {
            int begin = currIndex;
            while (currIndex < s.Length && s[currIndex] >= '0' && s[currIndex] <= '9')
                currIndex += 1;

            return currIndex > begin;
        }

        /// <summary>
        /// [+/-][A][.][B][e/E][+/-][A]
        /// LeetCode 官方题解状态机
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsNumber2(string s)
        {
            Dictionary<State, Dictionary<CharType, State>> transfer = new Dictionary<State, Dictionary<CharType, State>>();
            
            Dictionary<CharType, State> initialDictionary = new Dictionary<CharType, State> {
                {CharType.CHAR_SPACE, State.STATE_INITIAL},
                {CharType.CHAR_NUMBER, State.STATE_INTEGER},
                {CharType.CHAR_POINT, State.STATE_POINT_WITHOUT_INT},
                {CharType.CHAR_SIGN, State.STATE_INT_SIGN}
            };

            transfer.Add(State.STATE_INITIAL, initialDictionary);

            Dictionary<CharType, State> intSignDictionary = new Dictionary<CharType, State> {
                {CharType.CHAR_NUMBER, State.STATE_INTEGER},
                {CharType.CHAR_POINT, State.STATE_POINT_WITHOUT_INT}
            };

            transfer.Add(State.STATE_INT_SIGN, intSignDictionary);

            Dictionary<CharType, State> integerDictionary = new Dictionary<CharType, State> {
                {CharType.CHAR_NUMBER, State.STATE_INTEGER},
                {CharType.CHAR_EXP, State.STATE_EXP},
                {CharType.CHAR_POINT, State.STATE_POINT},
                {CharType.CHAR_SPACE, State.STATE_END}
            };

            transfer.Add(State.STATE_INTEGER, integerDictionary);

            Dictionary<CharType, State> pointDictionary = new Dictionary<CharType, State> {
                {CharType.CHAR_NUMBER, State.STATE_FRACTION},
                {CharType.CHAR_EXP, State.STATE_EXP},
                {CharType.CHAR_SPACE, State.STATE_END}
            };

            transfer.Add(State.STATE_POINT, pointDictionary);

            Dictionary<CharType, State> pointWithoutIntDictionary = new Dictionary<CharType, State> {
                {CharType.CHAR_NUMBER, State.STATE_FRACTION}
            };

            transfer.Add(State.STATE_POINT_WITHOUT_INT, pointWithoutIntDictionary);
            Dictionary<CharType, State> fractionDictionary = new Dictionary<CharType, State> {
                {CharType.CHAR_NUMBER, State.STATE_FRACTION},
                {CharType.CHAR_EXP, State.STATE_EXP},
                {CharType.CHAR_SPACE, State.STATE_END}
            };

            transfer.Add(State.STATE_FRACTION, fractionDictionary);

            Dictionary<CharType, State> expDictionary = new Dictionary<CharType, State> {
                {CharType.CHAR_NUMBER, State.STATE_EXP_NUMBER},
                {CharType.CHAR_SIGN, State.STATE_EXP_SIGN}
            };
            transfer.Add(State.STATE_EXP, expDictionary);

            Dictionary<CharType, State> expSignDictionary = new Dictionary<CharType, State> {
                {CharType.CHAR_NUMBER, State.STATE_EXP_NUMBER}
            };
            transfer.Add(State.STATE_EXP_SIGN, expSignDictionary);

            Dictionary<CharType, State> expNumberDictionary = new Dictionary<CharType, State> {
                {CharType.CHAR_NUMBER, State.STATE_EXP_NUMBER},
                {CharType.CHAR_SPACE, State.STATE_END}
            };
            transfer.Add(State.STATE_EXP_NUMBER, expNumberDictionary);

            Dictionary<CharType, State> endDictionary = new Dictionary<CharType, State>() {
                {CharType.CHAR_SPACE, State.STATE_END}
            };

            transfer.Add(State.STATE_END, endDictionary);

            int length = s.Length;
            State state = State.STATE_INITIAL;

            for (int i = 0; i < length; i++)
            {
                CharType type = ToCharType(s[i]);
                if (!transfer[state].ContainsKey(type))
                {
                    return false;
                }
                else
                {
                    state = transfer[state][type];
                }
            }
            return state == State.STATE_INTEGER || state == State.STATE_POINT || state == State.STATE_FRACTION || state == State.STATE_EXP_NUMBER || state == State.STATE_END;
        }

        CharType ToCharType(char ch)
        {
            if (ch >= '0' && ch <= '9')
            {
                return CharType.CHAR_NUMBER;
            }
            else if (ch == 'e' || ch == 'E')
            {
                return CharType.CHAR_EXP;
            }
            else if (ch == '.')
            {
                return CharType.CHAR_POINT;
            }
            else if (ch == '+' || ch == '-')
            {
                return CharType.CHAR_SIGN;
            }
            else if (ch == ' ')
            {
                return CharType.CHAR_SPACE;
            }
            else
            {
                return CharType.CHAR_ILLEGAL;
            }
        }

        enum State
        {
            STATE_INITIAL,
            STATE_INT_SIGN,
            STATE_INTEGER,
            STATE_POINT,
            STATE_POINT_WITHOUT_INT,
            STATE_FRACTION,
            STATE_EXP,
            STATE_EXP_SIGN,
            STATE_EXP_NUMBER,
            STATE_END
        }

        enum CharType
        {
            CHAR_NUMBER,
            CHAR_EXP,
            CHAR_POINT,
            CHAR_SIGN,
            CHAR_SPACE,
            CHAR_ILLEGAL
        }
    }
}
