using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018.November
{
    public static class No18_4Sum
    {
        public static List<List<int>> fourSum(int[] nums, int target)
        {
            List<List<int>> ans = new List<List<int>>();
            if (nums == null || nums.Length == 0) return ans;
            List<int> list = new List<int>();
            nums.OrderBy(x => x);
            getSum(nums, 0, target, ans, list, 0);
            return ans;
        }

        private static void getSum(int[] nums, int sum, int target, List<List<int>> ans, List<int> list, int pos)
        {
            if (list.Count() == 4 && sum == target && !ans.Contains(list))
            {
                ans.Add(new List<int>(list));
                return;
            }
            else if (list.Count() == 4) return;

            for (int i = pos; i < nums.Length; i++)
            {
                if (nums[i] + nums[nums.Length - 1] * (3 - list.Count()) + sum < target) continue;
                if (nums[i] * (4 - list.Count()) + sum > target) return;
                list.Add(nums[i]);
                getSum(nums, sum + nums[i], target, ans, list, i + 1);
                list.Remove(list.Count() - 1);
            }
        }
    }
}
