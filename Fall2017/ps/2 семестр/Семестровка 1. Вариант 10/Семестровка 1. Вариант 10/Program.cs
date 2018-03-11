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

            CircleList list = new CircleList { Data = participant1 };
            list.Next = new CircleList { Data = participant2 };
            list.Next.Next = new CircleList { Data = participant3 };

            list.Show(list);

            Participant participant4 = new Participant { Name = "Sarah", Gender = "woman" };
            list.Insert(list, participant4);

            list.Delete(list, "Jessica");

            Console.WriteLine(list.ParticipantLast(list, 2));

            Console.WriteLine(list.Gender(list));

            Console.WriteLine(list.Sort(list));
        }
    }
}
