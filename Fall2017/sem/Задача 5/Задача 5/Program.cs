using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int c;
            int a1 = int.Parse(a);
            int b1 = int.Parse(b);
            if (((a1 % 4) == 0) | ((b1 % 4) == 0))  // Находим длину временного промежутка, и количество високосных лет получает нахождением остатка от деления на 4. Если 1 или оба граничных числа делятся нацело на 4, то прибавляем 1
                c = (b1 - a1) / 4 + 1;
            else
                c = (b1 - a1) / 4;
            Console.WriteLine(c);


        }
    }
}
