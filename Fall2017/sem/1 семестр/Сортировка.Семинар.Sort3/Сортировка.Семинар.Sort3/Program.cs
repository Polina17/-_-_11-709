using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сортировка.Семинар.Sort3
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, number;  //min - минимальный элемент, number - индекс минимального элемента
            int[] arr = new int[int.Parse(Console.ReadLine())];
            string[] str = Console.ReadLine().Split(' ');
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(str[i]);  //Вводим элементы массива в строку
            /*  Просматривая весь массив, отыскиваем наименьшее число и меняем его местами 
            с первым элементом. Затем просматриваем элементы массива, начиная со второго, 
            снова находится наименьший, который меняется местами со вторым и т. д.
            */
            for (int i = 0; i < arr.Length - 1; i++)  
            {
                min = arr[i];
                number = i;
                for (int j = i + 1; j < arr.Length; i++)
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        number = j;
                    }
                arr[number] = arr[i];
                arr[i] = min;
            }
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
    }
}
