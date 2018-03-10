using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классная_работа_25._09.Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
    }
}
