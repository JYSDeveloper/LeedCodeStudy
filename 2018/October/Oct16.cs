using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018.October
{
    public static class Oct16
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1)
                return nums.Length;

            int lenth = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if(nums[i] != nums[i + 1])
                {
                    nums[lenth] = nums[i];
                    lenth++;
                    nums[lenth] = nums[i + 1];
                }
            }
            return lenth;
        }
    }
}
