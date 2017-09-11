using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача___8
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = Console.ReadLine(); // Вводим 6 чисел
            string b1 = Console.ReadLine(); //x1, x2 - координаты первой точки прямой
            string c1 = Console.ReadLine();
            string d1 = Console.ReadLine(); // y1, y2 - координаты второй точки прямой 
            string e1 = Console.ReadLine();
            string f1 = Console.ReadLine();  // x3, y3 - координаты точки, не лежащей на прямой
            double a, b, c, d, x, y;
            double x1 = double.Parse(a1);  // Преобразуем числа из типа string в тип double
            double y1 = double.Parse(b1);
            double x2 = double.Parse(c1);
            double y2 = double.Parse(d1);
            double x3 = double.Parse(e1);
            double y3 = double.Parse(f1);
            a =(y2 - y1) / (x2 - x1);      // Составляем уравнение прямой L. a- угловой коэффициент прямой L
            b = y1-a*x1;                   // Уравнение прямой L имеет вид y=a*x+b. Находим b 
            c = -1 / a;        // Составляем уравнение прямой, перпендикулярной L. Оно имеет вид: y=cx+d. Находим c- угловой коэффициент
            d = y3 - c * x3;   // Находим d из уравнения прямой, перпендикулярной L
            x = (d - b) / (a - c); // Находим координаты точки пересечения
            y = (c *x)+d;
            Console.WriteLine(x);
            Console.WriteLine(y);
            
        }
    }
}
