using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Семестровка_1.Вариант_10;

namespace Семестровка_1.Вариант_10
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForShow()
        {
            var list = new CircleList();
            Participant participant1 = new Participant { Name = "John", Gender = "man" };
            Participant participant2 = new Participant { Name = "Jessica", Gender = "woman" };
            Participant participant3 = new Participant { Name = "Mark", Gender = "man" };
            list.Show();
            Assert.AreEqual(3, list.Count());
            Assert.AreEqual("John", list.Head.Data.Name);
            Assert.AreEqual("man", list.Tail.Data.Gender);
        }

        public void TestForInsert()
        {
            var list = new CircleList();
            Participant participant1 = new Participant { Name = "John", Gender = "man" };
            Participant participant2 = new Participant { Name = "Jessica", Gender = "woman" };
            Participant participant3 = new Participant { Name = "Mark", Gender = "man" };
            list.Insert(participant1);
            list.Insert(participant2);
            list.Insert(participant3);
            Assert.AreEqual(3, list.Count());
        }

        public void TestForDelete()
        {
            var list = new CircleList();
            Participant participant1 = new Participant { Name = "John", Gender = "man" };
            Participant participant2 = new Participant { Name = "Jessica", Gender = "woman" };
            Participant participant3 = new Participant { Name = "Mark", Gender = "man" };
            Participant participant4 = new Participant { Name = "Sarah", Gender = "woman" };
            list.Insert(participant1);
            list.Insert(participant2);
            list.Insert(participant3);
            list.Delete("Jessica");
            Assert.AreEqual(2, list.Count());
            Assert.AreEqual(false, list.Contains(participant2));
        }

        public void TestForParticipantLast()
        {
            var list = new CircleList();
            Participant participant1 = new Participant { Name = "John", Gender = "man" };
            Participant participant2 = new Participant { Name = "Jessica", Gender = "woman" };
            Participant participant3 = new Participant { Name = "Mark", Gender = "man" };
            Participant participant4 = new Participant { Name = "Sarah", Gender = "woman" };
            list.Insert(participant1);
            list.Insert(participant2);
            list.Insert(participant3);
            list.Insert(participant4);
            list.ParticipantLast(2);
            Assert.AreEqual("Sarah", list.Tail.Data.Name);
            Assert.AreEqual("woman", list.Tail.Data.Gender);
        }

        public void TestForGender()
        {
            var list = new CircleList();
            Participant participant1 = new Participant { Name = "John", Gender = "man" };
            Participant participant2 = new Participant { Name = "Jessica", Gender = "woman" };
            Participant participant3 = new Participant { Name = "Mark", Gender = "man" };
            Participant participant4 = new Participant { Name = "Sarah", Gender = "woman" };
            list.Insert(participant1);
            list.Insert(participant2);
            list.Insert(participant3);
            list.Insert(participant4);
            var current = new CircleList[2];
            current = list.Gender();
            Assert.AreEqual(2, current[0].Count());
            Assert.AreEqual(2, current[1].Count());
            Assert.AreEqual("man", current[0].Head.Data.Gender);
            Assert.AreEqual("Sarah", current[1].Tail.Data.Name);
        }

        public void TestForSort()
        {
            var list = new CircleList();
            Participant participant1 = new Participant { Name = "John", Gender = "man" };
            Participant participant2 = new Participant { Name = "Jessica", Gender = "woman" };
            Participant participant3 = new Participant { Name = "Mark", Gender = "man" };
            Participant participant4 = new Participant { Name = "Sarah", Gender = "woman" };
            list.Insert(participant1);
            list.Insert(participant2);
            list.Insert(participant3);
            list.Insert(participant4);
            var sortList = new CircleList();
            sortList= list.Sort();
            Assert.AreEqual("Jessica", sortList.Head.Data.Name);
            Assert.AreEqual("John", sortList.Head.Next.Data.Name);
            Assert.AreEqual("Mark", sortList.Head.Next.Next.Data.Name);
            Assert.AreEqual("Sarah", sortList.Tail.Data.Name);
        }
    }
}
