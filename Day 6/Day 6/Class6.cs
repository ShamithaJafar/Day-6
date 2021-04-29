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
        public static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList();
            arraylist.Add(1);
            arraylist.Add("W");
            arraylist.Add(2);
            arraylist.Add("3");
            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
