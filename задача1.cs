using System;
using System.Globalization;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int a1 = int.Parse(a);
            int b1 = int.Parse(b);
            var c=a1;
            a1 = b1;
            b1 = c;
            a = a1.ToString();
            b = b1.ToString();
            Console.WriteLine(a);
            Console.WriteLine(b);
            
            
        }

    }
            
}
