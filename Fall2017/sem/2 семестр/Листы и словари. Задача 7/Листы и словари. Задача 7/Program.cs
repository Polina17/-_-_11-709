using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Листы_и_словари.Задача_7
{
    class Program
    {
        public static string LongestCommonSubstring(string str1, string str2)
        {
            int len = str1.Length;
            if (len == 0)
                return null;

            List<int[]> num = new List<int[]>();
            int maxLen = 0;
            int u = 0;  // номер последнего символа искомой подстроки в первой строке
            int v = 0;  // номер последнего символа искомой подстроки во второй строке
            for (int i = 0; i < len; i++)
            {
                num.Add(new int[len]);
                for (int j = 0; j < len; j++)
                {
                    if (str1[i] != str2[j])
                        num[i][j] = 0;
                    else
                    {
                        if ((i == 0) || (j == 0))
                            num[i][j] = 1;
                        else
                            num[i][j] = num[i - 1][j - 1] + 1;
                        if (num[i][j] > maxLen)
                        {
                            maxLen = num[i][j];
                            u = i;
                            v = j;
                        }
                    }
                }
            }
            return str1.Substring(u - maxLen + 1, maxLen);
        }

        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string result = LongestCommonSubstring(str1, str2);
            Console.WriteLine(result);
            Console.WriteLine(stopWatch.Elapsed);
        }
    }
}
