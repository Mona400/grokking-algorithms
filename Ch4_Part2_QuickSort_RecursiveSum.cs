using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Part2_QuickSort_RecursiveSum
{
    class Program
    {
        private static int Sum(IEnumerable<int> list)
        {
            if (!list.Any())
                return 0;
            return list.Take(1).First() + Sum(list.Skip(1));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new[] { 1,2,3,4}));
        }
    }
}
