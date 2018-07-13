using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetCode.Algorithms.Easy.Interfaces.Two_Sum;

namespace LetCode.Algorithms.Easy.Implementation.Two_Sum
{
    public class TwoSumSolution : ITwoSumSolution
    {
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
