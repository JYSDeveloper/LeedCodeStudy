using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018.September
{
    public static class Sep28
    {
        /*
         * Title: Palindrome Number
         * Description: 
                    Determine whether an integer is a palindrome. 
                    An integer is a palindrome when it reads the same backward as forward.
         * Example: Input: 121  Output: true
                    Input: -121 Output: false
                    Input: 10  Output: false
         * Note:
                Could you solve it without converting the integer to a string?
        */
        /*
         * My Answer
        public static bool IsPalindrome(long x)
        {
            if (x < 0 ||( x%10==0 && x!=0)) return false;
            int length = 1;
            long y = x;
            while(y/10 != 0)
            {
                y /= 10;
                length++;
            }
            Console.WriteLine($"length is {length}");
            for (int i = 1; i <= length/2; i++)
            {
                int j = length - i;
                var left = x / (long)Math.Pow(10, i - 1) % 10;
                var right = x / (long)Math.Pow(10, j) % 10;
                Console.WriteLine($"left is {left},right is {right}");
                if (left != right)
                    return false;
            }
            return true;
        }
        */

        //LeetCode Solution
        public static bool IsPalindrome(long x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            long revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            
            return x == revertedNumber || x == revertedNumber / 10;//后半段解决12321这种奇数个数字的问题。
        }

    }
}
