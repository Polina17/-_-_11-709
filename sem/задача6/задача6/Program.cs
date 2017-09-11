using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine(); //x1 y1 координаты первой точки прямой
            string b = Console.ReadLine();
            string c = Console.ReadLine(); // x2 y2 координаты второй точки прямой
            string d = Console.ReadLine();
            string e = Console.ReadLine(); // x3 y3 координаты точки, не лежащей на прямой
            string f = Console.ReadLine();
            double dl, dl1, dl2, p, S, k;
            double x1 = double.Parse(a);  // Преобразуем тип string в тип double
            double y1 = double.Parse(b);
            double x2 = double.Parse(c);
            double y2 = double.Parse(d);
            double x3 = double.Parse(e);
            double y3 = double.Parse(f);
            dl = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));  //Вычисляем длину отрезка на прямой c помощью теоремы Пифагора
            dl1 = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));  //Вычисляем длину отрезка, заключённого между точкой 1 на прямой и тоской, не лежащей на прямой
            dl2 = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));  //Вычисляем длину отрезка, заключённого между точкой 2 прямой и точкой, не лежащей на прямой
            p = (dl + dl1 + dl2) / 2;    // Находим по формуле Герона площадь треугольника с вершинами в 3х данных точках, p - полупериметр
            S = Math.Sqrt(p * (p - dl) * (p - dl1) * (p - dl2));  // Приравниваем 2 формулы площади треугольника (формула Герона и формула, выраженная через сторону и высоту, проведённую к ней
            k = 2 * S / dl;  // k - искомое расстояние от точки до прямой, выражаем его через равенство вышеупомянутых формул площади треугольника
            Console.WriteLine(k);






        }
    }
}
