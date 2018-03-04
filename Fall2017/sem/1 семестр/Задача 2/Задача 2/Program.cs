using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(a);
            int b1 = b / 100;  // Выделяем первую цифру числа (разряд сотен). Поскольку делимое и делитель типа integer, остаток при делении отбрасывается
            int b2 = (b / 10) % 10;  // Выделяем вторую цифру числа (разряд десятков)
            int b3 = b % 10;      // Выделяем третью цифру числа (разряд единиц) путём нахождения остатка от деления на 10
            int c = 100 * b3 + 10 * b2 + b1;   // Строим искомое число
            Console.WriteLine(c);
        }
    }
}
