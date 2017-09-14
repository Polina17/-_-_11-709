using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = Console.ReadLine();
            string b1 = Console.ReadLine();
            string c1 = Console.ReadLine();
            string d1 = Console.ReadLine();
            string e1 = Console.ReadLine();
            string f1 = Console.ReadLine();
            double a, b, c, d, x, y;
            double x1 = double.Parse(a1);
            double y1 = double.Parse(b1);
            double x2 = double.Parse(c1);
            double y2 = double.Parse(d1);
            double x3 = double.Parse(e1);
            double y3 = double.Parse(f1);
            a = (double)(y2 - y1) / (x2 - x1);
            b = y1 - a * x1;
            c = -1 / a;
            d = y3 - c * x3;
            x = (d - b) / (a - c);
            y = (c * (d - b)) / (d - c);
            Console.WriteLine(x);
            Console.WriteLine(y);




        }
    }
}
