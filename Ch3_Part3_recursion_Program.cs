using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_Part3_recursion
{
    class Program
    {
        private static int Fact(int item)
        {
            if (item <= 1)
                return 1;
            return item * Fact(item - 1);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Fact(5));
        }

    }
}
