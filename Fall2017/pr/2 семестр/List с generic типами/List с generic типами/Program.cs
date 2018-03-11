using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_с_generic_типами
{
    class Node
    {
        public T Data { get; set; }
        public Node Next { get; set; }
    }

    class GenericList<T>
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get { return count; } }

        public void Add(Task data)
        {
            if (Head == null)
            {
                Node root = new Node { Data = data };
                Root = root;
            }
            else
            {
                Node tail = new Node();
                Tail.Next = tail;
                Tail = tail;
                Tail.Next = Head;
            }

        }

        public void GetAtIndex(int i)
        {
            if (count < i) throw new InvalidOperationException();
            int currentIndex = 0;
            Node current = Root;
            while ((currentIndex != i) && (current.Next != null))
            {
                currentIndex++;
                current = current.Next;
            }
            return current.Data;
        }

        public void Remove(T data)
        {
            if (Root == null) throw new InvalidOperationException();

            var current = Root;
            for (int i = 0; i <)



        }

        class GenericList<T>
        {
            public T Data { get; set; }
            public GenericList<T> Next { get; set; }
            public GenericList<T> Tail;

            public void Add(GenericList<T> root, T data)
            {
                if (root == null)
                {
                    GenericList<T> current = new GenericList<T> { Data = data };
                    root = current;
                }
                else
                {
                    GenericList<T> tail = new GenericList<T>();
                    Tail.Next = tail;
                    Tail = tail;
                    Tail.Next = root;
                }
            }
        }




    }
}
}
