using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестровка_1.Вариант_10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Participant participant1 = new Participant { Name = "John", Gender = "man" };
            Participant participant2 = new Participant { Name = "Jessica", Gender = "woman" };
            Participant participant3 = new Participant { Name = "Mark", Gender = "man" };

            CircleList list = new CircleList();
            list.Head.Data = participant1;
            list.Head.Next = new ListItem { Data=participant2 };
            list.Tail = new ListItem { Data = participant3, Next=list.Head };

            list.Show();

            Participant participant4 = new Participant { Name = "Sarah", Gender = "woman" };
            list.Insert(participant4);

            list.Delete("Jessica");

            Console.WriteLine(list.ParticipantLast(2));

            Console.WriteLine(list.Gender());

            Console.WriteLine(list.Sort());
        }
    }
}
