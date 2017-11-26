using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестровка_2.Часть_1.Задача_10
{
    class Program
    {
        static double Consider(double x, int step)  //Метод суммирования
        {
            double sum;
            if (step == 0)
                sum = 1;  //На нулевом шаге получаем: 0!=1
            sum = 1;
            double numerator = 1;
            double denumerator = 1;
            for (int i = 1; i <= step; i++)
            {
                numerator *= x * x;  //Начиная с 1-го шага, числитель каждый раз умножаем на x^2
                denumerator *= 2 * i * (2 * i - 1);  //на 1-ом шаге знаменатель умножаем на 2*1, на 2- на 4*3, на 3- на 6*5 и т. д.
                sum += numerator / denumerator;  //Увеличиваем сумму
            }
            return sum;
        }

        static void Main(string[] args)
        {
            double accuracy = Convert.ToDouble(Console.ReadLine());  //Вводим значение точности с консоли
            double x = Convert.ToDouble(Console.ReadLine());
            int step = 0;
            while (Consider(x, step + 1) - Consider(x, step) > accuracy)  //На каждом шаге сраниваем значение на данном шаге со значением на следующем шаге, пока разница не станет меньше или равна точности 
                step++;
            Console.WriteLine(Consider(x, step));  //Выводим значение на последнем шаге, для которого верно вышестоящее условие
            Console.WriteLine("Точность достигается на шаге " + step);  //Выводим номер шага
        }
    }
}
