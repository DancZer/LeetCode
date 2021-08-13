using System;
using System.Collections.Generic;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();

            var target = 92;

            Console.WriteLine($"Target: {target}");

            var r = s.TwoSum(new []{3,2,95,4,-3}, target);

            Console.WriteLine("Result: "+string.Join(",", r)+":"+target);
        }
    }

    public class Solution {
        public int[] TwoSum(int[] nums, int target) 
        {
            var invalidVal = new HashSet<int>();

            for (int i = 0; i < nums.Length; ++i)
            {
                var vi = nums[i];
                if(invalidVal.Contains(vi)) continue;

                invalidVal.Add(vi);

                for (int ii = i+1; ii < nums.Length; ++ii)
                {
                    var sum = vi+nums[ii];
                    if(sum == target) return new []{i, ii};
                    //Console.WriteLine($"{i},{ii}:{sum}");
                }        
            }

            return new []{0,0};
        }
    }
}
