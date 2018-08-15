using System;
using System.Linq;
using LetCode.Algorithms.Easy.Interfaces.Two_Sum;

namespace LetCode.Algorithms.Easy.Implementation
{
    public class TwoSumSolution : ITwoSumSolution
    {
        public string GetDescription()
        {
            return "Given an array of integers, return indices of the two numbers such that they add up to a specific target. You may assume that each input would have exactly one solution, and you may not use the same element twice.  Given nums = [2, 7, 11, 15], target = 9, Because nums[0] + nums[1] = 2 + 7 = 9, return [0, 1].";
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int j = 1;
            for (int i = 0; i < nums.Count() - 1; i++)
            {
                if (nums[i] + nums[j] == target)
                {
                    Console.WriteLine(@"Two Sum Result - [{0}, {1}]", i, j);
                    return new[] { i, j };
                }

                j++;
            }

            return new int[2];
        }
    }
}
