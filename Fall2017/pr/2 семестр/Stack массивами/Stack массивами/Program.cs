using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_массивами
{
    public class Stack
    {
        private int[] items;
        private int count;

        public void Push(int value)
        {
            items[count] = value;
            count++;
        }

        public int Pop()
        {
            if (count != 0)
            {
                var result = items[count - 1];
                count--;
                return result;
            }
            else throw new InvalidOperationException();
        }

        public int Pech()
        {
            return items[count - 1];
        }
    }
}
