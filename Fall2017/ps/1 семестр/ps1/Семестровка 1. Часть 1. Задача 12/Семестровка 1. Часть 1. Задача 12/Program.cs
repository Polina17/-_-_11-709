using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестровка_1.Часть_1.Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');  //Вводим в строку 6 вещественных чисел, задающих треугольник
            double x1 = Convert.ToDouble(str[0]);  //Выделяем координаты вершин треугол ника из строки
            double y1 = Convert.ToDouble(str[1]);
            double x2 = Convert.ToDouble(str[2]);
            double y2 = Convert.ToDouble(str[3]);
            double x3 = Convert.ToDouble(str[4]);
            double y3 = Convert.ToDouble(str[5]);
            string[] str1 = Console.ReadLine().Split(' ');  //Вводим в строку 3 вещественных числа, задающих расстояния от точки до вершин треугольника
            double dl1 = Convert.ToDouble(str1[0]);  //Выделяем числа из строки
            double dl2 = Convert.ToDouble(str1[1]);
            double dl3 = Convert.ToDouble(str1[2]);
            double x, y, k;  //x, y - искомые координаты точки, k - вспомогательная переменная, значение которой несколько раз используется в окончательных формулах
            k = dl2 * dl2 - dl1 * dl1 + x1 * x1 - x2 * x2 + y1 * y1 - y2 * y2;
            x = ((dl3 * dl3 - dl1 * dl1 - x3 * x3 + x1 * x1 - y3 * y3 + y1 * y1) * (y1 - y2) - k * (y1 - y3)) / (2 * (x1 - x3) * (y1 - y2) - 2 * (y1 - y3) * (x1 - x2));
            y = k / 2 / (y1 - y2) - ((x1 - x2) / (y1 - y2)) * ((dl3 * dl3 - dl1 * dl1 - x3 * x3 + x1 * x1 - y3 * y3 + y1 * y1) * (y1 - y2) - k * (y1 - y3)) / (2 * (x1 - x3) * (y1 - y2) - 2 * (y1 - y3) * (x1 - x2));
            Console.WriteLine(x + " " + y);  //Выводим полученный результат в одну строку через пробел
        }
    }
}
