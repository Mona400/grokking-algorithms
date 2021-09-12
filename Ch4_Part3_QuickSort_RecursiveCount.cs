using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Part3_QuickSort_RecursiveCount
{
    class Program
    {
        private static int Count(IEnumerable<int> list)
        {
            if (!list.Any())
                return 0;
            return 1 + Count(list.Skip(1));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Count(new[] { 1,2,3,4,5,6}));
        }
    }
}
