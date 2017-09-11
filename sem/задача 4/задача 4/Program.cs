using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();  // Вводим с консоли число N и 2 простых числа X и Y
            string X = Console.ReadLine();  
            string Y = Console.ReadLine();
            int N1 = int.Parse(N);  // Преобразуем тип string в тип int
            int X1 = int.Parse(X);
            int Y1 = int.Parse(Y);
            int k=0;
            for (int i=1; i<N1; i++)   //Заводим цикл for от 1 до N
            {
                if (((i % X1) == 0) | ((i % Y1) == 0))
                    k++;         // Если требуемое условие выполняется, k увеличивается на 1

            }
            Console.WriteLine(k);
            
        }
    }
}
