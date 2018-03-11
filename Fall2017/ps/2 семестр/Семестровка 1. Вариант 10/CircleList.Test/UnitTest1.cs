using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Семестровка_1.Вариант_10;

namespace Семестровка_1.Вариант_10
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForInsert()
        {
            var list = new CircleList();
            Participant participant1 = new Participant { Name = "John", Gender = "man" };
            Participant participant2 = new Participant { Name = "Jessica", Gender = "woman" };
            Participant participant3 = new Participant { Name = "Mark", Gender = "man" };
            list.Insert(list, participant1);
            list.Insert(list, participant2);
            list.Insert(list, participant3);
            Assert.AreEqual(3, list.Count(list));
        }

        public void TestForDelete()
        {
            var list = new CircleList();
            Participant participant1 = new Participant { Name = "John", Gender = "man" };
            Participant participant2 = new Participant { Name = "Jessica", Gender = "woman" };
            Participant participant3 = new Participant { Name = "Mark", Gender = "man" };
            Participant participant4 = new Participant { Name = "Sarah", Gender = "woman" };
            list.Insert(list, participant1);
            list.Insert(list, participant2);
            list.Insert(list, participant3);
            list.Delete(list, "Jessica");
            Assert.AreEqual(2, list.Count(list));
        }

        public void TestForParticipantLast()
        {
            var list = new CircleList();
            Participant participant1 = new Participant { Name = "John", Gender = "man" };
            Participant participant2 = new Participant { Name = "Jessica", Gender = "woman" };
            Participant participant3 = new Participant { Name = "Mark", Gender = "man" };
            Participant participant4 = new Participant { Name = "Sarah", Gender = "woman" };
            list.Insert(list, participant1);
            list.Insert(list, participant2);
            list.Insert(list, participant3);
            list.Insert(list, participant4);
            Assert.AreEqual("Sarah", list.Tail.Data.Name);
            Assert.AreEqual("woman", list.Tail.Data.Gender);
        }
    }
}
