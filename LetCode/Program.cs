using System;
using LetCode.Algorithms;

namespace LetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithms = new AlgorithmsCore();

            algorithms.EasyAlgorthms.TwoSumSolution.TwoSum(new int[] {2,5,5,11}, 10);

            Console.ReadLine();
        }
    }
}
