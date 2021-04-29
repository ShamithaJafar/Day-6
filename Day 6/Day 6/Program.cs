using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Program
    {
        public static Tuple<double,double,double,double> Addsubmuldiv(double a,double b)
        {
            return new Tuple<double,double, double, double>((a + b),(a-b), (a * b), (a/b));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------************** Basic Calculator **********----------------------");

            double a, b;
            Console.WriteLine("Enter first number:  ");

            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:  ");
            b = Convert.ToDouble(Console.ReadLine());
            Tuple<double, double,double, double> output = Program.Addsubmuldiv(a, b);
            Console.WriteLine("Sum is " + output.Item1+"\n" + "Subtraction value = " + output.Item2 + "\n" + "Multiplication value = " + output.Item3 + "\n" + "Division value = "+ output.Item4);
            Console.ReadLine();
        }
    }
}
