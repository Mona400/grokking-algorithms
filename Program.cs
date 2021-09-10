using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2_1_Selection_Sort
{
    class Program
    {
      private static int FindSmallest(List<int>arr)
        {
            var smallest = arr[0];
            var smallestIndex = 0;
            for(int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                    smallestIndex = i;
                }

            }
            return smallestIndex;
        }

        private static int[] SelectionSort(List<int>arr)
        {
            var newArr = new int[arr.Count()];
            for(int i = 0; i < newArr.Count(); i++)
            {
                var smallest = FindSmallest(arr);
                newArr[i] = arr[smallest];
                arr.RemoveAt(smallest);
            }
            return newArr;
        }
        static void Main(string[] args)
        {

           var list = new List<int> { 5, 3, 6, 2, 10 };
            Console.WriteLine(string.Join(",", SelectionSort(list)));

        }
    }
}
