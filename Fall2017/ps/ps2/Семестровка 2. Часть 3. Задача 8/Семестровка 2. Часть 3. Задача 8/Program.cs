using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестровка_2.Часть_3.Задача_8
{
    class Program
    {
        static double Function(double x)  //Метод, возвращающий значение заданной функции в конкретной точке
        {
            double f = Math.Sin(2 * x) / Math.Cos(x) / Math.Cos(x);
            return f;
        }

        static double LeftRectangle(int n)  //Метод левых прямоугольников, n - количество итераций
        {
            double step = 1.5 / n;  //Шаг итерации 
            double sum = 0;
            for (int i = 0; i <= (n - 1); i++)
            {
                double x = i * step;
                sum += Function(x);  //Считаем сумму значений на левых границах каждого шага
            }
            double result = sum * step;  //Затем умножаем полученное значение суммы на длину шага
            return result;
        }

        static double RightRectangle(int n)  //Метод левых прямоугольников, n - количество итераций
        {
            double step = 1.5 / n;  //Шаг итерации
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double x = i * step;
                sum += Function(x);  //Считаем сумму значений на правых границах каждого шага
            }
            double result = sum * step;  //Затем умножаем полученное значение суммы на длину шага
            return result;
        }

        static double Trapeze(int n)  //Метод трапеций, n - количество итераций
        {
            double step = 1.5 / n;  //Шаг итерации
            double sum = 0;
            double a = 0;  //Границы интегрирования
            double b = 1.5;
            for (int i = 1; i <= (n - 1); i++)
            {
                double x = i * step;
                sum += Function(x);  //Считаем сумму значений на границах каждого шага, за исключением a и b
            }
            sum *= 2;  //Удваиваем её
            sum +=Function(a)+Function(b);  //Прибавляем значения на границах интегрирования
            double result = sum * step / 2;  //Умножаем на половину шага
            return result;
        }

        static double Sympson(int n)  //Метод Симпсона, n - количество итераций
        {
            double step = 1.5 / n / 2;  //Шаг равен половине длины итерации
            double x;
            double sumOfOddNodes = 0;  
            double sumOfEvenNodes = 0;
            double a = 0;  //Границы интегрирования
            double b = 1.5;
            for (int i = 1; i <= n; i++)
            {
                x = step * (2 * i - 1);
                sumOfOddNodes += Function(x);  //Находим сумму значений функции на нечётных узлах
            }
            sumOfOddNodes *= 4;
            for (int i = 1; i <= n - 1; i++)
            {
                x = step * 2 * i;
                sumOfEvenNodes += Function(x);  //Находим сумму значений функции на чётных узлах
            }
            sumOfEvenNodes *= 2;  //Удваиваем её
            double result = (step / 3) * (sumOfOddNodes + sumOfEvenNodes + Function(a)+Function(b));  //К полученной сумме прибавляем значения на границах интегрирования и умножаем на 1/3 шага
            return result;
        }

        static double MonteKarlo(int n)  //Метод Монте-Карло, n - шаг итерации
        {
            double step = 1.5 / n;
            double sum = 0;
            for (int i = 1; i <= n; i++)  
            {
                double x = i * step;
                sum += Function(x);
            }
            double result = sum * step;
            return result;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  //Считываем количество итераций
            Console.WriteLine(LeftRectangle(n));  //Выводим полученные значения
            Console.WriteLine(RightRectangle(n));
            Console.WriteLine(Trapeze(n));
            Console.WriteLine(Sympson(n));
            Console.WriteLine(MonteKarlo(n));
        }
    }
}
