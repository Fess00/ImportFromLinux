using System.Reflection.Metadata;
using System;

namespace test
{
    static class St {
        
        public static int price = 0;
        public static string stuff = "None"; 

        static St() {
            price = 2;
            stuff = "Bat";
        }

        public static void Show() {
            string converter =  price.ToString();
            Console.WriteLine(converter + " " + stuff);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            St.Show();
            St.price = 3;
            St.Show();
        }
    }

}
