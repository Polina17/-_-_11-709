using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_односвязный_список
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var root = new Node<int> { Value = 0 };
            root.Next = new Node<int> { Value = 1 };
            root.Next.Next = new Node<int> { Value = 2 };

            var list = new CustomList<int> { Root = root, Tail = root.Next.Next, Count=3 };

            list.Reverse();
        }
    }

    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }

    class CustomList<T> 
    {
        public Node<T> Root { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; set; }
        public int Reverse (Node<T> root)
        {
            var list = new CustomList<T>() { Root = null };
            while (Root.Next != null)
            {
                var value = Tail.Value;
                Root.Value = Tail.Value;
                Tail.Value = value;
                Count--;
                int i = 1;
                Tail = root;
                while (i!=Count)
                {
                    Tail = Tail.Next;
                }
                current = current.Next;
            }
            return root;
        }
    }
}
