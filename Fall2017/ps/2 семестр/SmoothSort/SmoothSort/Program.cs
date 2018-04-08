using System;
using System.Diagnostics;

namespace SmoothSort
{
    public class Program
    {
        public static void Main()
        {
            int size = 10000;
            int[] array = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(-100000, 100000);
            }
            var sv = new Stopwatch();
            sv.Start();
            array.Sort();
            sv.Stop();
            Console.WriteLine(sv.ElapsedMilliseconds);
        }
    }
}