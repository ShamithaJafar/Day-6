using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Class3
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "sam");
            keyValuePairs.Add(2, "sid");
            keyValuePairs.Add(3, "Divya");
            if(keyValuePairs.ContainsKey(4) == true)
            {
                Console.WriteLine("Key Found");
            }
            else
            {
                Console.WriteLine("Key not Found");
            }
            if (keyValuePairs.ContainsValue("sam"))
            {
                Console.WriteLine("value found");

            }
            else
            {
                Console.WriteLine("value not found");

            }
            Console.ReadLine();

        }
    }

}