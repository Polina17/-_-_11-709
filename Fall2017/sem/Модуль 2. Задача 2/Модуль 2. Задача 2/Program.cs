using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Модуль_2.Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch = int.Parse(Console.ReadLine());   //Часы
            int min= int.Parse(Console.ReadLine());   //Минуты
            int k;
            k = (Math.Abs(min - (ch%12) * 5 - min / 12)) * 6;  //На циферблате 60 чёрточек, 1 чёрточка=6 градусов. Между соседними числами 5 чёрточек, по 12 минут
            if (k > 180)
            {
                Console.WriteLine("Ответ:");
                Console.WriteLine(360 - k);
            }
            else
            {
                Console.WriteLine("Ответ:");
                Console.WriteLine(k);
            }
        }
    }
}
