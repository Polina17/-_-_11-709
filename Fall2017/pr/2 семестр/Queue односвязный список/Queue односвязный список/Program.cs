using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_односвязный_список
{
    class CustomQueue<T>
    {
        public class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }
            public Node Prev { get; set; }
        }

        class Queue
        {
            Node Head { get; set; }
            Node Tail { get; set; }
            public int Count { get; set; }

            public T First()
            {
                if (Count == 0) throw new InvalidOperationException();
                else
                    return Head.Value;
            }

            public T Last()
            {
                if (Count == 0) throw new InvalidOperationException();
                if (Count == 1)
                    return Head.Value;
                else
                    return Tail.Value;
            }

            public void Enqueue(T value)
            {
                if (Head == null)
                    Head = Tail = new Node { Value = value };
                else
                {
                    var item = new Node { Value = value };
                    Tail.Next = item;
                    item.Prev = Tail;
                    Tail = item;
                }
            }

            public T Dequeue()
            {
                if (Head == null) throw new InvalidOperationException();
                var result = Head.Value;
                Head = Head.Next;
                if (Head == null)
                    Tail = null;
                return result;
            }
        }

        class Program
        {
            static void Main()
            {
                var queue = new Queue();
                for (int i = 0; i < 3; i++)
                    queue.Enqueue(i);
                for (int i = 0; i < 3; i++)
                    Console.WriteLine(queue.Dequeue());
            }
        }
    }
}