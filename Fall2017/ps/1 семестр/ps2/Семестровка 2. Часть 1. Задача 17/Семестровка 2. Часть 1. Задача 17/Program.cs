using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестровка_2.Часть_1.Задача_17
{
    class Program
    {
        static double Consider(long step)  //Метод суммирования
        {
            double sum=0;
            double numerator, denumerator;
            for (int i = 0; i <= step; i++)
            {
                if (i % 2 == 0)  //если номер шага чётный, то числитель равен 1, иначе -1
                    numerator = 1;
                else
                    numerator = -1;
                denumerator = (2*i+1)*(2*i+1);  //Знаменатель получаем, подставляя в формулу номер шага
                sum += numerator / denumerator;  //Увеличиваем сумму
            }
            return sum;
        }

        static void Main(string[] args)
        {
            double accuracy = Convert.ToDouble(Console.ReadLine());  //Вводим точность
            long step = 0;  //На маленьких значениях точности значение шага, на котором она достигается, может принимать больше значения, поэтому переменная step имеет тип long
            while (Math.Abs(Consider(step + 1) - Consider(step)) > accuracy)  //На каждом шаге сраниваем модуль на данном шаге со значением на следующем шаге, пока модуль разности не станет меньше или равен точности 
                step++;
            Console.WriteLine(Consider(step));  //Выводим значение на последнем шаге, для которого верно вышестоящее условие
            Console.WriteLine("Точность достигается на шаге " + step);  //Выводим номер шага
        }
    }
}
