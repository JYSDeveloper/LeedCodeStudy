using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018.October
{
    public static class Oct17
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            int n = nums.Length;
            while (i < n)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[n - 1];
                    // reduce array size by one
                    n--;
                }
                else
                {
                    i++;
                }
            }
            return n;
        }
    }
}
