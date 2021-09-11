using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_Part1_recursion
{
    class Program
    {
        private static void Countdown(int i)
        {
            Console.WriteLine(i);
            if (i <= 0)   //base case
                return ;

           Countdown(i - 1);   // recursive case
        }
        static void Main(string[] args)
        {
            Countdown(10); 
        }
    }
}
