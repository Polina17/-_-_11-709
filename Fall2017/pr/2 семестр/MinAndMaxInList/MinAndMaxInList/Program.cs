using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndMaxInList
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public static void Search(Node root)
        {
            var current = root;
            var min = current.Value;
            var max = current.Value;
            while (current.Next != null)
            {
                current = current.Next;
                if (current.Value > max)
                    max = current.Value;
                if (current.Value < min)
                    min = current.Value;
            }
            Console.WriteLine("{0} {1}", min, max); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node { Value = 6 };
            root.Next = new Node { Value = 2 };
            root.Next.Next = new Node { Value = 4 };
            root.Next.Next.Next = new Node { Value = 9 };
            Node.Search(root);
        }
    }
}
