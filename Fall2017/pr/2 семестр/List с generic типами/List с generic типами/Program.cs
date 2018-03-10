using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_с_generic_типами
{
    class Program
    {

        Generic List<T> 
        {
            public Node Root { get; set; }
            private int count;
            class Node
            {
                public Node Next { get; set; }
                public T Data { get; set; }
            }
            
            public int Count { get { return count; } }
            
            public Node Tail { get; set; }

            public void Add (Task data)
            {
                if (Root==null)
                {
                    Node root = new Node { Data = data };
                    Root = root;
                }
                else
                {
                    Node tail = new Node();
                    Tail.Next = tail;
                    Tail = tail;
                }

            }

            public void GetAtIndex (int i)
            {
                if (count < i) throw new InvalidOperationException();
                int currentIndex=0;
                Node current = Root;
                while ((currentIndex!=i)&&(current.Next!=null))
                {
                    currentIndex++;
                    current = current.Next;
                }
                return current.Data;
            }

            public void Remove (T data)
            {
            if (Root == null) throw new InvalidOperationException();

            var current = Root;
            for (int i=0; i<)

            
            }


            
            

    }
}
}
