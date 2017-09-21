using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классная_работа_18._09_Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if ((x * x - y * y) >= 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
