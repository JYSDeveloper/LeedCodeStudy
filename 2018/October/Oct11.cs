using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018.October
{
    public static class Oct11
    {
        private static Dictionary<char, char> matchValue = new Dictionary<char, char>() {
            {')','(' },
            { ']','['},
            { '}','{'}
        };

        public static bool method(string input)
        {
            if (input == string.Empty || input.Length % 2 != 0)
                return false;

            int startIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!matchValue.ContainsKey(input[i]))
                {
                    if (2 * i - startIndex -1 > input.Length)
                        return false;
                    if (!isMatchValue(input,startIndex,i))
                        return false;
                    startIndex = i + startIndex + 1;
                }
                else
                {
                    continue;
                }
            }
            return true;
        }

        private static bool isMatchValue(string input,int startIndex,int flag)
        {
            var temp = flag;
            for (int i = startIndex; i < flag; i++)
            {
                if (matchValue[input[i]] != input[temp])
                    return false;
                temp++;
            }
            return true;
        }

        public static bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length % 2 != 0)
                return false;
            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (matchValue.ContainsKey(s[i]))
                {
                    if (stack.Peek() != matchValue[s[i]])
                        return false;
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                }
            }
            return stack.Count == 0;
        }
    }
}
