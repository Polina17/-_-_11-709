using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace SmoothSort
{
    public class Program
    {
        public static void Main()
        {
            var data = new ArraysCreator(55);
            data.WriteArray();

            var filename = @"C:\Users\Полина\source\repos\SmoothSort.txt";
            var ListOfArray = new List<int[]>();
            var arrays = File.ReadAllText(filename).Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var array in arrays)
                ListOfArray.Add(array.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray());

            foreach (var array in ListOfArray)
            {
                var sv = new Stopwatch();
                sv.Start();
                array.Sort();
                sv.Stop();
                Console.WriteLine(sv.ElapsedMilliseconds);
            }
        }
    }
}