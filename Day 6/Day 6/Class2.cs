using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items to be included in list: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> mylist = new List<int>();
            Console.WriteLine("Enter the number in list: ");
            
            for (int i = 0;i<n;i++)
            {

                int x = Convert.ToInt32(Console.ReadLine());
                mylist.Add(x);
            }
            foreach(var item in mylist)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            foreach (var item in mylist)
            {
                if(item %2 == 0)
                {
                    Console.WriteLine("even number");
                }
                else
                {
                    Console.WriteLine("odd number");
                }
            }
            Console.ReadLine();
        }
    }
}
