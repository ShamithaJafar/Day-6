using System;

using System.Collections;
using System.Collections.Generic;

namespace Day_4
{
    public class Product
    {

        public int pdtno { get; set; }
        public String name { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int number { get; set; }
        public int code { get; set; }




        public void InputValues()
        {



            Dictionary<int, string> keyValuePairs = new Dictionary<int, string >();
            Console.WriteLine("Enter the name: ");
            string name = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {

                keyValuePairs.Add(i, name);
               

            }
            Console.ReadLine();

            Dictionary<int, int> keyValuePairs1 = new Dictionary<int, int>();
            Console.Write("Enter quantity : ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {

                keyValuePairs1.Add(i, quantity);

            }
            Console.ReadLine();

            Dictionary<int, int> keyValuePairs2 = new Dictionary<int, int>();
            Console.Write("Enter price : ");
            int price = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {

                keyValuePairs2.Add(i, price);

            }
            Console.ReadLine();

            //Console.Write("Enter serial number : ");
            //pdtno = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter product type : ");
            //name = Console.ReadLine();
            //Console.Write("Enter quantity : ");
            //quantity = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter price : ");
            //price = Convert.ToInt32(Console.ReadLine());



        }



    }
      public class Invoice : Product
    {
        private IEnumerable<KeyValuePair<int, string>> keyValuePairs;
        private IEnumerable<KeyValuePair<int, int>> keyValuePairs1;
        private IEnumerable<KeyValuePair<int, int>> keyValuePairs2;

        public void PrintInvoice(Product[] products)
        {
           




        

            Console.WriteLine("-------------------Invoice------------------------");
            Console.Write("index  \t");
            Console.Write("Product No \t");
            Console.Write("Name \t\t");
            Console.Write("quantity \t");
            Console.Write("price \t");
            Console.Write("totalprice \n");
            //int index = 1;
            foreach (var item in products)
            {

                foreach (KeyValuePair<int, string> kvp in keyValuePairs)
                {

                   Console.WriteLine(kvp.Key);

                   Console.WriteLine(kvp.Value);

                }
                Console.ReadKey();
                foreach (KeyValuePair<int, int> kvp1 in keyValuePairs1)
                {
                    Console.WriteLine(kvp1.Value);
                }
                Console.ReadKey();
                foreach (KeyValuePair<int, int> kvp2 in keyValuePairs2)
                {
                    Console.WriteLine(kvp2.Value);
                }
                Console.ReadKey();




                //Console.Write(index + "\t");
                //Console.Write(item.pdtno + "\t");
                //Console.Write(item.name + "\t\t");
                //Console.Write(item.quantity + "\t\t");
                //Console.Write(item.price + "\t");
                //Console.Write((item.price) * (item.quantity));
                //Console.Write("\n");
                //index = index + 1;
            }

        }


    }


    class User
    {

        public static void Main()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Product[] products = new Product[number];

                Product product = new Product();
                product.InputValues();
               
            
            Invoice invoice = new Invoice();
            invoice.PrintInvoice(products);
            Console.ReadLine();

        }
    }
}


