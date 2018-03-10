using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классная_работа_18._09.Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            for (int i=1; i<=1000000; i++)
            {
                for (int j=1; j<=1000000; j++)
                {
                    if ((i % j) == 0)
                        k ++;
                }
                if (k == 2)
                    Console.WriteLine(i);
                k = 0;
            }
        }
    }
}
