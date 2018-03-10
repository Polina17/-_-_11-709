using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестровка_2.Часть2.Задача_2
{
    class Program
    {
        static double Consider(long step)  //Метод нахождения значения на конкретном шаге
        {
            double multiplication = 1;  //Изначально произведение равно единице
            double numerator, denumerator;
            for (int i = 1; i <= step; i++)
            {
                numerator = 4 * i * i;
                denumerator = 4 * i * i - 1;
                multiplication *= numerator / denumerator;  //На каждом шаге умножаем полуенное произведение на дробь, согласно формуле
            }
            return multiplication*2;  //Удваиваем полученное произведение
        }

        static void Main(string[] args)
        {
            double accuracy = Convert.ToDouble(Console.ReadLine());  //Вводим значение точности с консоли
            long step = 1;
            while (Math.Abs(Consider(step + 1) - Consider(step)) > accuracy)  //На каждом шаге сраниваем значение на данном шаге со значением на следующем шаге, пока разница не станет меньше или равна точности 
                step++;
            Console.WriteLine(Consider(step));  //Выводим значение на последнем шаге, для которого верно вышестоящее условие
            Console.WriteLine("Точность достигается на шаге " + step);  //Выводим номер шага
        }
    }
}
