using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классная_работа_25._09.Задача_1.Решение_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 4, 6, 15, 63, 1 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
    }
}
