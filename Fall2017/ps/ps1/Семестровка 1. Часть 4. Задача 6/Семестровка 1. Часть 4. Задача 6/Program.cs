using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестровка_1.Часть_4.Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  //Вводим с консоли число n
            int sum, sum1, k, k1; //sum - сумма делителей числа a, sum1 - сумма делителей числа b, k, k1 - параметры делителей
            for (int a=1; a<=n-1; a++)  //Перебираем все возможные числа a
            {
                sum = 0; 
                for (k=1; k<=a;  k++)  //Находим сумму делителей числа a
                {
                    if ((a % k) == 0)
                        sum+=k;
                }
                for (int b=a+1; b<=n; b++)  //Для каждого числа a перебираем все возможные числа b, тем самым проверяя все возможные пары на дружественность
                {
                    sum1 = 0;
                    for (k1 = 1; k1 <= b; k1++)  //Находим сумму делителей числа b
                    {
                        if ((b % k1) == 0)
                            sum1 += k1;
                    }
                    if ((sum == sum1) & (sum == (a + b)) & ((a + b) < n))  //Если суммы делителей совпадают, равны a+b и сумма этих дружественных чисел меньше заданного числа, то выводим пару этих чисел на консоль
                    {
                        Console.WriteLine(a+" "+b);  //Выводим в одну строку через пробел
                    }

                }
            }
        }
    }
}
