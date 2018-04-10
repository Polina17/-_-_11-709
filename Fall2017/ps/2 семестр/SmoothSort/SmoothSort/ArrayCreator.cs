using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SmoothSort
{
    class ArraysCreator
    {
        public readonly int Count;
        public readonly List<string[]> ListOfArray;
        public ArraysCreator(int count)
        {
            Count = count;
            ListOfArray = GetArrays(Count);
        }
        public List<string[]> GetArrays(int count)
        {
            var list = new List<string[]>();
            var random = new Random();
            for (int i = 0; i < Count; i++)
            {
                var array = new string[random.Next(100, 10000)];
                for (int j = 0; j < array.Length; j++)
                {
                    if (j != array.Length - 1)
                        array[j] = Convert.ToString(random.Next(10000000)) + ",";
                    else if (i != Count - 1)
                        array[j] = Convert.ToString(random.Next(10000000)) + ";";
                    else
                        array[j] = Convert.ToString(random.Next(10000000));
                }
                list.Add(array);
            }
            return list;
        }
        public void WriteArray()
        {
            foreach (var e in ListOfArray)
                File.AppendAllLines(@"C:\Users\Полина\source\repos\SmoothSort.txt", e);
        }
    }
}