using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестровка_2.Часть_4.Задача_1
{
    class Program
    {
        static int[] TranslateIntoNumbers(string longDigit)
        {
            int len = longDigit.Length;
            int[] arrayOfNumbers = new int[len];
            for (int i = len - 1; i >= 0; i--)
            {
                arrayOfNumbers[len - i - 1] = longDigit[i];
            }
            return arrayOfNumbers;
        }

        static int[] SummOfDigit(int[] firstArray, int[] secondArray)
        {
            int length, min, sum;
            if (firstArray.Length > secondArray.Length)
            {
                length = firstArray.Length + 1;
                min = secondArray.Length;
            }
            else
            {
                length = secondArray.Length + 1;
                min = firstArray.Length;
            }
            int[] resultArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (i <= min - 1)
                    sum = firstArray[i] + secondArray[i];
                else if (firstArray.Length > secondArray.Length)
                    sum = firstArray[i];
                else
                    sum = secondArray[i];

                if (resultArray[i] + sum >= 10)
                {
                    resultArray[i] = (resultArray[i] + sum) % 10;
                    resultArray[i + 1] = (resultArray[i] + sum) / 10;
                }
                else
                {
                    resultArray[i] += sum;
                    resultArray[i + 1] = 0;
                }
            }
            return resultArray;
        }

        static string Output(int[] arrayOfNumber)
        {
            int l = arrayOfNumber.Length;
            string digit;
            digit = null;
            for (int i = l - 1; i >= 0; i--)
            {
                digit += arrayOfNumber[l - i - 1];
            }
            return digit;
        }

        static string Factorial(int k)
        {
            int result = 1;
            for (int i = 1; i <= k; i++)
                result *= i;
            result *= result;
            return result.ToString();
        }
        static void Main(string[] args)
        {

            int p = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            string sum = Output(SummOfDigit(TranslateIntoNumbers(p), TranslateIntoNumbers(k)));
            Console.WriteLine(sum);


        }
    }
}

