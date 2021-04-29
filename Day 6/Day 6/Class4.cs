using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Class4
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            Console.WriteLine("Enter the string: ");
            string string1 = Convert.ToString(Console.ReadLine());
           
            for (int i = 0; i < string1.Length; i++)
            {
                if (keyValuePairs.ContainsKey(Convert.ToString(string1[i]))) 
                {
                    int x = keyValuePairs[Convert.ToString(string1[i])];
                    keyValuePairs[Convert.ToString(string1[i])] = x + 1;
                }
                else
                {
                    keyValuePairs.Add(Convert.ToString(string1[i]), 1);  
                }
            }
            foreach (KeyValuePair<string, int> kvp in keyValuePairs)
            {
                Console.WriteLine(kvp.Key + " Counts: " + kvp.Value);  
            }
            Console.ReadKey();
        }
    }
}
