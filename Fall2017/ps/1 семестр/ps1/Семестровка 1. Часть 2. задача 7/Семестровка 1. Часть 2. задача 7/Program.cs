using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестровка_1.Часть_2.задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа от 1 до 100");  //Пояснение для пользователя, что нужно ввести
            string[] str = Console.ReadLine().Split(' ');  // Вводим 2 числа в строку через пробел  
            int a = Convert.ToInt32(str[0]);     // a - первое число, b - второе число
            int b = Convert.ToInt32(str[1]);
            int result = (-2) * a * b;   // Результат равен a*a+b*b-(a+b)*(a+b)=a*a+b*b-a*a-2*a*b-b*b=-2*a*b (взаимно уничтожаем квадраты чисел)
            Console.WriteLine(result);   // Выводим результат на консоль
        }
    }
}
