using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестровка_1.Часть_2.Задача_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  //Вводим число n
            int k = int.Parse(Console.ReadLine());  //Вводим k - основание системы счисления
            int tekZnach, count, maxCount;  //tekZnach - текущий остаток от деления n на k, count - количество цифр в текущей непрерывно неубывающей цепочке, maxCount - искомое максимальное количество
            maxCount = 0;
            count = 0;
            tekZnach = 11;
            while (n > 0)
            {

                if ((n % k) <= tekZnach)  //В задаче речь идёт о непрерывно неубывающих цепочках, но при переводе в k-ичную СС остатки от деления на k записываются в обратном порядке, поэтому в данном коде представлено условие невозрастания (<=)
                {
                    count++;  //Если условие невозрастания соблюдается, то количество цифр в текущей непрерывно неубывающей цепочке увеличивается на 1
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                    tekZnach = n % k; //Остаток от деления n на k становится tekZnach
                }
                else
                {
                    count = 1;  //Если условие невозрастания не соблюдается, то текущее количество становится равным 1, и начинается новая последовательность
                    tekZnach = n % k;
                }
                n = n / k;
            }
            Console.WriteLine(maxCount);  //Выводим результат на консоль
        }
    }
}
