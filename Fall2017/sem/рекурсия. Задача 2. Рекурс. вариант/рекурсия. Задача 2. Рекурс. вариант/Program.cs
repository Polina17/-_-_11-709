using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace рекурсия.Задача_2.Рекурс.вариант
{
    class Program
    {
        static int[,] Multiplication(int[,] matrix1, int[,] matrix2)  ////Метод принимает 2 матрицы 2*2, перемножает их и возвращает результат
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
            int number = int.Parse(Console.ReadLine());
            int[,] resultMatrix = new int[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    resultMatrix[i, j] = mainMatrix[i, j];  //Итоговая матрица изначально равна базовой
            resultMatrix = ExponentiationOfMatrix(resultMatrix, number);  //Возводим итоговую матрицу в степень number с помощью нижеследующего метода
            int f = resultMatrix[0, 0];  //n-ым числом Фибоначчи является число, записанное в итоговой матрице в первой строке на первом месте (считая с 1)
            Console.WriteLine(f);  
        }
        static int[,] ExponentiationOfMatrix(int[,] matrix, int n)  //Метод возводит матрицу в степень n с помощью рекурсии
        {
            if (n == 1)
                return matrix;
            return Multiplication(ExponentiationOfMatrix(matrix, n - 1), matrix);
        }
    }
}
