using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace рекурсия.Задача_2.Нерекурс.вариант
{
    class Program
    {
        static int[,] Multiplication(int[,] matrix1, int[,] matrix2)   //Метод принимает 2 матрицы 2*2, перемножает их и возвращает результат
        {
            int[,] resultMatrix = new int[2, 2];
            resultMatrix[0, 0] = matrix1[0, 0] * matrix2[0, 0] + matrix1[0, 1] * matrix2[1, 0];
            resultMatrix[0, 1] = matrix1[0, 0] * matrix2[0, 1] + matrix1[0, 1] * matrix2[1, 1];
            resultMatrix[1, 0] = matrix1[1, 0] * matrix2[0, 0] + matrix1[1, 1] * matrix2[1, 0];
            resultMatrix[1, 1] = matrix1[1, 0] * matrix2[0, 1] + matrix1[1, 1] * matrix2[1, 1];
            return resultMatrix;
        }

        static void Main(string[] args)
        {
            int[,] mainMatrix = new int[2, 2];  //Базовой матрицей 2*2 при вычислении чисел Фибоначчи является следующая матрица
            mainMatrix[0, 0] = 1;
            mainMatrix[0, 1] = 1;
            mainMatrix[1, 0] = 1;
            mainMatrix[1, 1] = 0;
            int number = int.Parse(Console.ReadLine());  //Для того, чтобы получить n-ое число Фибоначчи, мы возводим базовую матрицу в степень n
            int[,] resultMatrix= new int[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    resultMatrix[i, j] = mainMatrix[i, j];  //Итоговая матрица изначально равна базовой
            for (int i=2; i<=number; i++)  //Пока параметр не достигнет введённого значения number, мы умножаем базовую матрицу саму на себя
            {
                resultMatrix = Multiplication(resultMatrix, mainMatrix);
            }
            int f = resultMatrix[0, 0];  //n-ым числом Фибоначчи является число, записанное в итоговой матрице в первой строке на первом месте (считая с 1)
            Console.WriteLine(f);
        }
    }
}
