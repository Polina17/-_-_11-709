using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестровка_1.Вариант_10
{
    public class ListItem
    {
        public Participant Data { get; set; }
        public ListItem Next { get; set; }
    }

    public class CircleList
    {
        public ListItem Head { get; set; }
        public ListItem Tail { get; set; }

        public int Count()
        {
            var list = this.Head;
            int i = 0;
            var current = list;
            while (current.Next != list)
            {
                i++;
                current = current.Next;
            }
            return i + 1;
        }

        public bool Contains(Participant participant)
        {
            var list = this.Head;
            var current = list;
            while (current.Next != list)
            {
                if ((current.Data.Name == participant.Name) & (current.Data.Gender == participant.Gender))
                    return true;
            }
            if ((this.Tail.Data.Name == participant.Name) & (this.Tail.Data.Gender == participant.Gender))
                return true;
            return false;
        }

        public void Show()
        {
            var list = this.Head;
            if (list == null) throw new NullReferenceException();
            var current = list;
            while (current.Next != list)
            {
                Console.WriteLine("{0} {1}", current.Data.Name, current.Data.Gender);
                current = current.Next;
            }
            Console.WriteLine("{0} {1}", current.Data.Name, current.Data.Gender);
        }

        public void Insert(Participant participant)
        {
            var list = this.Head;
            if (list == null)
            {
                var root = new ListItem { Data = participant };
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
                if ((current == this.Tail) & (this.Tail.Data.Name != participant.Name) & (this.Tail.Data.Gender != participant.Gender))
                {
                    ListItem tail = new ListItem { Data = participant };
                    this.Tail.Next = tail;
                    this.Tail = tail;
                    this.Tail.Next = this.Head;
                }
            }
        }

        public void Delete(string name)
        {

            var list = this.Head;
            var current = list;
            while (current.Next != list)
            {
                if (current.Next.Data.Name == name)
                {
                    var extra = current.Next;
                    current.Next = extra.Next;
                    extra = null;
                }
                current = current.Next;
            }
            if (list.Data.Name == name)
            {
                var extra = list;
                this.Tail = extra.Next;
                extra = null;
            }
        }

        public Participant ParticipantLast(int k)
        {
            var list = this.Head;
            int i = 1;
            var current = list;
            while (current.Next != list)
            {
                if ((i - 1) % k == 0)
                    Delete(current.Data.Name);
                current = current.Next;
                i++;
            }
            if ((i - 1) % k == 0)
                Delete(this.Tail.Data.Name);
            return this.Tail.Data;
        }

        public CircleList[] Gender()
        {
            var current = new CircleList[2];
            var list = this.Head;
            var root = list;
            while (root.Next != list)
            {
                if (root.Data.Gender == "man")
                    current[0].Insert(root.Data);
                else
                    current[1].Insert(root.Data);
                root = root.Next;
            }
            if (this.Tail.Data.Gender == "man")
                current[0].Insert(this.Tail.Data);
            else
                current[1].Insert(this.Tail.Data);
            return current;
        }

        public CircleList Sort()
        {
            var list = this.Head;
            int count = this.Count();
            var arr = new Participant[count];
            var current = list;
            int k = 0;
            while (current.Next != list)
            {
                arr[k] = current.Data;
                k++;
                current = current.Next;
            }
            arr[count - 1] = this.Tail.Data;
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
                sortList.Insert(arr[b]);
            }
            return sortList;
        }
    }
}
