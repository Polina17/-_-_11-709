using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, countOfChet, maxCountOfChet;  //a - очередное число, countOfChet - текущее количество чётных чисел, maxCountOfChet - максимальное количество чётных чисел
            countOfChet = 0;
            maxCountOfChet = 0;
            a = int.Parse(Console.ReadLine());
            while (a != 0)
            {
                if ((a % 2) == 0)
                {
                    countOfChet++;   // Если число делится на 2, то текущее кол-во чётных чисел увеличивается на 1
                }
                else if ((a % 2) != 0)  // Если встречается нечётное число, максимальному значению мы присваиваем длину текущей чётной подпоследовательности (если полученная длина больше максимального значения), countOfChet обнуляем, чтобы затем сосчитать количество чисел в следующей чётной подпоследовательности
                {
                    if (countOfChet > maxCountOfChet)
                    {
                        maxCountOfChet = countOfChet;
                    }
                    countOfChet = 0;
                }
                a = int.Parse(Console.ReadLine());
            }
            if (countOfChet > maxCountOfChet)    // Если последовательность заканчивается чётным числом, то мы сравниваем длину последней подпоследовательности с maxCountOfChet
                Console.WriteLine(countOfChet);
            else
                Console.WriteLine(maxCountOfChet);
        }
    }
}
