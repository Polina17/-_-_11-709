using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классная_работа_21._09_Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int god = int.Parse(Console.ReadLine());
            if (((god % 100) != 0) & ((god % 4) == 0))
                Console.WriteLine("366");
            else
                Console.WriteLine("365");
        }
    }
}
