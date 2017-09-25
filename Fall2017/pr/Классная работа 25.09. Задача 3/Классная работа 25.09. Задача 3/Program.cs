using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классная_работа_25._09.Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 21, -6, 6, 33, -7, -5 };
            int countPol = 0;
            int countOtr = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    countPol++;
                }
                else
                {
                    countOtr++;
                }
            }
            if (countPol > countOtr)
            {
                Console.WriteLine("Положительных элементов больше");
            }
            else if (countOtr > countPol)
            {
                Console.WriteLine("Отрицательных элементов больше");
            }
            else
            {
                Console.WriteLine("Отрицательных и положительных элементов поровну");
            }
        }
    }
}
