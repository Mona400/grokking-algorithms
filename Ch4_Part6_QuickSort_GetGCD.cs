using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Part6_QuickSort_GetGCD
{
    class Program
    {
        //Get great Comman Divisor
        public static int GetGCD(int FirstNumber, int SecondNumber)
            => SecondNumber == default ? FirstNumber : GetGCD(SecondNumber, FirstNumber % SecondNumber);

        //Get great Comman Divisor of list
        public static int GetGCDList(List<int> lst)
        {
            var result = lst[0];
            result = GetGCD(result, lst.Skip(1).FirstOrDefault());
            return result;
        }

        static void Main(string[] args)
        {
            var lst = new List<int> { 32, 696, 40, 50 };
            var GCD = GetGCD(640, 1680);
            var GCDList = GetGCDList(lst);
            Console.WriteLine(GCD);
            Console.WriteLine(GCDList);
        }
    }
}
