using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_Part2_HashTable_Check_Voter
{
    class Program
    {
       
        public static Dictionary<string, bool> _voted = new Dictionary<string, bool>();
        public static void Main(string[] args)
        {

            _voted.Add("tom", false);
            _voted.Add("mike", false);
            _voted.Add("sara", true);
            _voted.Add("Mona", false);

            CheckVoter("tom");
            CheckVoter("mike");
            CheckVoter("sara");
            CheckVoter("Mohamed");
        }

        private static void CheckVoter(string name)
        {

            if (_voted.ContainsKey(name))
            {
                Console.WriteLine("kick them out!");
            }
            else
            {
                _voted.Add(name, true);
                Console.WriteLine("let them vote!");
            }
        }
    }
}
