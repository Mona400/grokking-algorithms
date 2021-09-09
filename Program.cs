using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1_introduction_to_algorithms
{
   public class Program
    {
        private static int? BinarySearch(IList<int>list,int item)
            {
            var low = 0;
            var high = list.Count() - 1;
            while (low <= high)
            {
                var mid=(low+high)/2;
                var guess=list[mid];
                if (guess == item)
                    return mid;
                if (guess > item)
                    high = mid - 1;
                else
                    low = mid + 1;

            }
            return null;
            }
        public static void Main(string[] args)
        {
            var mylist = new List<int> { 1, 2, 5, 8, 9 };
            Console.WriteLine(BinarySearch(mylist, 2));  //1
            Console.WriteLine(BinarySearch(mylist, 9));  //4
            Console.WriteLine(BinarySearch(mylist, -1)); //null
            Console.WriteLine(BinarySearch(mylist, 0));  //null

        }


    }
}
