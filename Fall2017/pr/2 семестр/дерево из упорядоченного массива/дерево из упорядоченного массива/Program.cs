using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дерево_из_упорядоченного_массива
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Count { get; set; }

        public void Fill (int[] arr)
        {
            int count = arr.Length;
            int middle = arr[arr.Length / 2 + 1];
            var tree = new Node();
            while
        }
            
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
