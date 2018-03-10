using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_02._03
{
    public class Stack
    {
        List<int> list = new List<int>();

        public void Push(int value)
        {
            list.Add(value);
        }

        public int Pop()
        {
            if (list.Count == 0) throw new InvalidOperationException();
            var result = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return result;
        }
        
        public int Max()
        {
            int max = list[0];
            for (int i=1; i<list.Count; i++)
            {
                if (list[i] > max)
                    max = list[i];
            }
            return max;
        }

        public string Execute(string query)
        {
            var stack = new Stack<int>();
            string command = query.Split(' ')[0];

            if (command == "1")
            {
                int number = int.Parse(query.Split(' ')[1]);
                stack.Push(number);
                return null;
            }

            else if (command == "2")
            {
                stack.Pop();
                return null;
            }

            else  //command 3
            {
                return stack.Max().ToString();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stack = new Stack();
            for (int i = 0; i < n; i++)
            {
                var query = Console.ReadLine();
                if (query == null) continue;
                var result = stack.Execute(query);
                if (result != null)
                    Console.WriteLine(result);
            }
        }
    }
}
