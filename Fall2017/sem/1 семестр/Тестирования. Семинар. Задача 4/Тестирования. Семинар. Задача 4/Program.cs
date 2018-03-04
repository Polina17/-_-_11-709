using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестирования.Семинар.Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int limit = 163842;   // 163841 - 15000-ое простое число (+1 - для размера массива)
            int k = int.Parse(Console.ReadLine());  //количество чисел, вводимых с консоли
            var inputData = new int[k];  //массив входных данных
            for (int i = 0; i < k; i++)
            {
                inputData[i] = int.Parse(Console.ReadLine());  //вводим данные
            }

            // Решето Эратосфена для поиска простых чисел
            Console.WriteLine("Результаты:");
            for (var n = 0; n < k; n++)
            {
                var table = new bool[limit];  //массив, который показывает, является ли число простым 

                // Отмечаем все числа как простые
                for (int i = 0; i < table.Length; i++)
                    table[i] = true;

                // Вычеркиваем лишнее
                for (int i = 2; i < table.Length; i++) 
                    if (table[i] == true)               //Если число не вычеркнуто, то зачёркиваем с списке от удвоенного числа до конца все числа с шагом, равным этому числу
                        for (int j = 2 * i; j < table.Length; j += i)
                            table[j] = false;

                int cnt = 0;
                
                // Выводим найденное
                for (int i = 2; i < table.Length; i++)  //считаем n-ое простое число
                {
                    if (table[i] == true)
                    {
                        cnt++;
                        if (inputData[n] == cnt)
                        {
                            Console.WriteLine("Входное число: {0}, простое число = {1}.", inputData[n], i);
                            break;
                        }
                    }
                }
            }
        }
    }
}
