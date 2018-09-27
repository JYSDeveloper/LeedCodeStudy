using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018.September
{
    public static class Sep27
    {
        /*
         * Title: Reverse Integer
         * Description: 
                    Given a 32-bit signed integer, reverse digits of an integer.
         * Example: Input: 123  Output: 321
                    Input: -123 Output: -321
                    Input: 120  Output: 21
         * Note:
                Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−2^31, 2^31 − 1]. 
                For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows
        */
        public static int Reverse(int x)
        {
            int rev = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7)) return 0;
                if (rev < int.MinValue / 10 || (rev == int.MinValue / 10 && pop < -8)) return 0;
                rev = rev * 10 + pop;
            }
            return rev;
        }
        //public static int Reverse(int x)
        //{
        //    return (x >= 0 ? 1 : -1) * int.Parse(Math.Abs(x).ToString().Reverse());
        //}
    }
}
