using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Class1
    {
        static void Main(string[] args)
        {
            var tuple = Tuple.Create(1, 2, 3, 4, Tuple.Create(5, 6), 7, 8);
            
            Console.WriteLine( tuple.Item1 + tuple.Item2 + tuple.Item3 + tuple.Item4 + tuple.Item5.Item1 + tuple.Item5.Item2 + tuple.Item6 + tuple.Item7);

            Console.ReadLine();
        }
    }
}
