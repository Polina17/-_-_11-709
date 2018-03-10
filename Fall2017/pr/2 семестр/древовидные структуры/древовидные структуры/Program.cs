using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace древовидные_структуры
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Node
            {
                Value = 1
            };
            tree.Left = new Node
            {
                Value = 2
            };
            tree.Right = new Node
            {
                Value = 3
            };
            tree.Left.Left = new Node
            {
                Value = 4
            };
            tree.Left.Right = new Node
            {
                Value = 5
            };
            tree.Right.Right = new Node
            {
                Value = 6
            };
        }
    }
}
