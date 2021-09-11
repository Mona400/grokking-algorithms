using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_Part2_recursion
{
    class Program
    {
        public static void Greet(string name)
        {
            Console.WriteLine($"Hello {name}!");
            Greet2(name);
            Console.WriteLine("getting ready to say bye...");
            Bye();
        }
        public static void Greet2(string name)
        {
            Console.WriteLine($"How are you {name} ?");
        }

        public static void Bye()
        {
            Console.WriteLine("ok bye!");
        }

        static void Main(string[] args)
        {
            Greet("adit");
        }
    }
}
