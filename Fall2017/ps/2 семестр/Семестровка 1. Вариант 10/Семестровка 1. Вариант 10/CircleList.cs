using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестровка_1.Вариант_10
{
    public class CircleList
    {
        public Participant Data { get; set; }
        public CircleList Next { get; set; }

        public CircleList Head { get; set; }
        public CircleList Tail { get; set; }

        public int Count(CircleList list)
        {
            int i = 0;
            var current = list;
            while (current.Next != list)
            {
                i++;
                current = current.Next;
            }
            return i + 1;
        }

        public void Show(CircleList list)
        {
            var current = list;
            while (current.Next != list)
            {
                Console.WriteLine("{0} {1}", current.Data.Name, current.Data.Gender);
                current = current.Next;
            }
            Console.WriteLine("{0} {1}", current.Data.Name, current.Data.Gender);
        }

        public void Insert(CircleList list, Participant participant)
        {
            if (list == null)
            {
                var root = new CircleList { Data = participant };
                list = root;
            }
            else
            {
                var current = list;
                while (current.Next != list)
                {
                    if ((current.Data.Name == participant.Name) && (current.Data.Gender == participant.Gender))
                        break;
                    current = current.Next;
                }
                if ((current == list.Tail) & (current.Tail.Data.Name != participant.Name) & (current.Tail.Data.Gender != participant.Gender))
                {
                    CircleList tail = new CircleList { Data = participant };
                    list.Tail.Next = tail;
                    list.Tail = tail;
                    list.Tail.Next = list;
                }
            }
            Console.WriteLine(list);
        }

        public void Delete(CircleList list, string name)
        {
            var current = list;
            while (current.Next != list)
            {
                if (current.Next.Data.Name == name)
                {
                    var root = current.Next;
                    current.Next = root.Next;
                    root = null;
                }
                current = current.Next;
            }
            if (list.Data.Name == name)
            {
                var root = list;
                list.Tail = root.Next;
                root = null;
            }
            Console.WriteLine(list);
        }

        public Participant ParticipantLast(CircleList list, int k)
        {
            int i = 1;
            var current = list;
            while (current.Next != list)
            {
                if ((i - 1) % k == 0)
                    Delete(list, current.Data.Name);
                current = current.Next;
                i++;
            }
            if ((i - 1) % k == 0)
                Delete(list, list.Tail.Data.Name);
            return list.Tail.Data;
        }

        public CircleList[] Gender(CircleList list)
        {
            var current = new CircleList[2];
            var root = list;
            while (root.Next != list)
            {
                if (root.Data.Gender == "man")
                    Insert(current[0], root.Data);
                else
                    Insert(current[1], root.Data);
                root = root.Next;
            }
            if (root.Tail.Data.Gender == "man")
                Insert(current[1], root.Tail.Data);
            else
                Insert(current[1], root.Tail.Data);
            return current;
        }

        public CircleList Sort(CircleList list)
        {
            int count = Count(list);
            var arr = new Participant[count];
            var current = list;
            int k = 0;
            while (current.Next != list)
            {
                arr[k] = current.Data;
                k++;
                current = current.Next;
            }
            arr[count - 1] = list.Tail.Data;
            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (String.Compare(arr[i].Name, arr[j].Name) > 0)
                    {
                        Participant a = arr[i];
                        arr[i] = arr[j];
                        arr[j] = a;
                    }
                }
            }
            CircleList sortList = new CircleList();
            for (int b = 0; b < count; b++)
            {
                Insert(sortList, arr[b]);
            }
            return sortList;
        }
    }
}
