using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Part1_Qui_Loop_Sum
{
    class Program
    {
        private static int Sum(IEnumerable<int> arr)
        {
            var total = 0;
            foreach (var item in arr)
            {
                total += item;
            }
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new[] { 1, 2, 3, 4 }));
        }
    }
}
