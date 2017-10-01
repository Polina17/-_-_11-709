using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестровка_1.Часть_4.Задача_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine()); //Вводим целое число k
            int max;  //max - искомая максимальная длина 
            max = 0;
            for (int a1 = 1; a1 <= k; a1++) //a1 - число, с которого начинается подпоследовательность (первый член арифметической прогрессии) 
            {
                for (int n = 1; n <= k; n++)  //n - количество чисел в последовательности
                {
                    if ((((2 * a1 + n - 1) * n / 2) == k) & (n > max)) //по данной формуле находится сумма n членов арифметической прогрессии при разности прогрессии 1
                        max = n;
                    if (((2 * a1 + n - 1) * n / 2) >= k)  //Если сумма членов последовательности уже больше введённого числа, то цикл следует прекратить 
                        break;
                }
            }
            Console.WriteLine(max);  //Выводим на консоль найденную максимальную длину
        }
    }
}
