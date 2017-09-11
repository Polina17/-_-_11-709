using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(a);
            if (b % 12 <= 6)
                Console.WriteLine((b % 12) * 30);  // Если часовая стрелка направлена на число от 1 до 6, то искомый угол получаем путём умножения этого числа на 30 (расстояние между соседними числами циферблата - 30 градусов)
            else
                Console.WriteLine((12 - b % 12) * 30);  // В противном случае от 12 отнимаем это число и результат умножаем на 30
            

        }
    }
}
