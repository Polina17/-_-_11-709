using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeld_return
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }

   public class CustomList<T> : IEnumerable<T>
    {
        public Node<T> Root;
        public int Count;

        // Реализуем интерфейс IEnumerator
        IEnumerator IEnumerable.GetEnumerator()
        {
            Node<T> current = Root;
            while (current!=null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private IEnumerator<T> GetEnumerator()
        {
            return new CustomListEnumerator<T>();
        }

        private class CustomListEnumerator<T> : IEnumerator<T>
        {
            T IEnumerator<T>.Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            #region IDisposable Support
            private bool disposedValue = false; // Для определения избыточных вызовов

            protected virtual void Dispose(bool disposing)
            {
                if (!disposedValue)
                {
                    if (disposing)
                    {
                        // TODO: освободить управляемое состояние (управляемые объекты).
                    }

                    // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                    // TODO: задать большим полям значение NULL.

                    disposedValue = true;
                }
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }
    }

  
}


class Program
{
    static void Main(string[] args)
    {
    }
}
}
