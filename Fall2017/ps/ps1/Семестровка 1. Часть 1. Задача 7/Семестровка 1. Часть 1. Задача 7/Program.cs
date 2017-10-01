using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестровка_1.Часть_1.Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');   //Вводим 3 числа в строку через пробел
            double dl1 = Convert.ToDouble(str[0]);   // Конвертируем числа в тип double          
            double dl2 = Convert.ToDouble(str[1]);
            double dl3 = Convert.ToDouble(str[2]);
            if ((dl1 < (dl2 + dl3)) & (dl2 < (dl1 + dl3)) & (dl3 < (dl1 + dl2)))  // По теореме о неравенстве треугольника каждая сторона треугольника меньше суммы двух других его сторон. Если это условие выполняется, то треугольник существует, в обратном случае - нет
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
