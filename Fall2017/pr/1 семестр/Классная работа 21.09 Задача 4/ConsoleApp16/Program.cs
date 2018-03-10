using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            while (a>0)
            {
                sum = sum + (a % 10);
                a = a / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
