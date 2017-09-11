using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_1_решение_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int a1 = int.Parse(a);
            int b1 = int.Parse(b);
            int c;  // Меняем местами 2 числа с использованием третьей переменной
            c = a1;
            a1 = b1;
            b1 = c;
            Console.WriteLine(a1);
            Console.WriteLine(b1);
        }
    }
}
