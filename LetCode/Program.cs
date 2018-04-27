using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithms.Algorithms algorithms = new Algorithms.Algorithms();

            algorithms.EasyAlgorthms.TwoSumSolution.TwoSum(new int[] {2,5,5,11}, 10);

            Console.ReadLine();
        }
    }
}
