using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');  //Вводим числа в строку через пробел
            double h = Convert.ToDouble(str[0]);           //Выделяем числа из строки, записываем в переменные
            double t = Convert.ToDouble(str[1]);
            double v = Convert.ToDouble(str[2]);
            double x = Convert.ToDouble(str[3]);
            double tmin, tmax;
            tmin = (h - x * t) / (v - x);  // h=v*tmin + x*(t-tmin); h-х*t=v*tmin-х*tmin; h-x*t=tmin*(v-x); tmin=(h-x*t)/(v-x)
            tmax = t;         //Мы можем весь путь двигаться на максимальной скорости, поэтому tmax=t
            Console.Write("{0} {1}", tmin, tmax);
        }
    }
}
