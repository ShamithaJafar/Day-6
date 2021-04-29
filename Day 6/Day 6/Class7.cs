using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Class6
    {
        public static void Main()
        {
            SortedList sortedList = new SortedList();

            sortedList.Add(2, "Dog");
            sortedList.Add(1, "CAT");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine("Key is" + item.Key + "Value is " + item.Value);
            }
            SortedList<int, string> keyValues = new SortedList<int, string>();
            keyValues.Add(3, "NASA");
            keyValues.Add(1, "ISRO");
            keyValues.Add(2, "CNSA");
            foreach (var item in keyValues)
            {
                Console.WriteLine("Rank is" + item.Key + "Value is " + item.Value);
            }
            Console.ReadLine();
        }

    }
}