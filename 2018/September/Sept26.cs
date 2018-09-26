﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018.September
{
    /*
     * Title: Two Sum
     * Description: 
                    Given an array of integers, 
                    return indices of the two numbers such that they add up to a specific target.
                    You may assume that each input would have exactly one solution, 
                    and you may not use the same element twice.
     * Example: Given nums = [2, 7, 11, 15], target = 9,
                Because nums[0] + nums[1] = 2 + 7 = 9,
                return [0, 1].
     */
    public class Sept26
    {
        /*
        public int[] twoSum(int[] args, int target)
        {
            for (int i = 0; i < args.Length-1; i++)
            {
                for (int j = i+1; j < args.Length; j++)
                {
                    if (target == args[i] + args[j])
                        return new int[] { i, j };
                }
            }
            return null;
        }
        */
        public int[] twoSum(int[] args,int target)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < args.Length; i++)
            {
                dic.Add(args[i], i);
                if (target < args[i]) continue;
                var subValue = target - args[i];
                if (dic.ContainsKey(subValue))
                    return new int[] { dic[subValue],i };
            }
            return null;
        }
    }
}
