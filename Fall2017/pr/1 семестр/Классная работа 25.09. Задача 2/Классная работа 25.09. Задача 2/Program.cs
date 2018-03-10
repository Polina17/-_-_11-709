using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классная_работа_25._09.Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 45, 25, 7, 5 };
            int max;
            max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
