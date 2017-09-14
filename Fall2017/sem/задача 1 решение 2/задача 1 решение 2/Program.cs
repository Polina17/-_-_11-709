using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача2_решение_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int a1 = int.Parse(a);
            int b1 = int.Parse(b);
            b1 = a1 + b1;    // Меняем местами 2 числа без использования третьей переменной
            a1 = b1 - a1;
            b1 = b1 - a1;
            Console.WriteLine(a1);
            Console.WriteLine(b1);



        }
    }
}
