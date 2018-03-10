using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Замкнутый_список
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public void Put(Node root, int value)
        {
            var current = root;
            while (current.Next!=root)
            {
                var Next = current.Next;
                if ((current.Value<value)&(Next.Value>value))
                {
                    var node = new Node();
                    node.Value = value;
                    node.Next = Next;
                    current.Next = node;
                    Console.WriteLine("{0} {1} {2}", current.Value, node.Value, Next.Value);
                    break;
                }
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var root = new Node { Value = 2 };
            root.Next = new Node { Value = 4 };
            root.Next.Next = new Node { Value = 6 };
            root.Next.Next.Next = new Node { Value = 9 };
            root.Put(root, 5);
        }
    }
}
