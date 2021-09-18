using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH5_HashTable_Part1_Price_Of_Groceries
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, decimal>();
            book.Add("apple", 0.67m);
            book.Add("milk", 1.49m);
            book.Add("avocado", 1.49m);
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
