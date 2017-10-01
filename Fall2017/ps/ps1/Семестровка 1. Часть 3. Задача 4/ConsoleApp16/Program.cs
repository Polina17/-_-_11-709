using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //Вводим количество пар n
            double sMin1, sMin2, sMin3, s, sum; //sMin1 - самая маленькая площадь, sMin2 - самая маленькая из оставшихся, sMin3 - самая маленькая, не считая sMin2 и sMin1
            sMin1 = 100000000000000000000000000.0;
            sMin2 = 100000000000000000000000001.0;
            sMin3 = 100000000000000000000000002.0;

            for (int i = 1; i <= n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');  //Вводим 2 числа в строку через пробел
                double a = Convert.ToDouble(str[0]);           //Выделяем числа из строки, записываем в переменные
                double b = Convert.ToDouble(str[1]);
                s = a * b;   //Находим площадь текущего прямоугольника
                if (s <= sMin1)  //Проверяем, входит ли его площадь в тройку самых маленьких  
                {
                    sMin3 = sMin2;
                    sMin2 = sMin1;
                    sMin1 = s;
                }
                if ((s > sMin1) & (s <= sMin2))
                {
                    sMin3 = sMin2;
                    sMin2 = s;
                }
                if ((s > sMin2) & (s <= sMin3))
                {
                    sMin3 = s;
                }

            }

            sum = sMin1 + sMin2 + sMin3; //Находим сумму найденных минимальных площадей
            Console.WriteLine(sum);

        }
    }
}
