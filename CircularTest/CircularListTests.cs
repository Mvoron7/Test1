using NUnit.Framework;
using System.Collections.Generic.Circular;

namespace CircularTest {
    public class CircularListTests {
        
        [SetUp]
        public void Setup() {

        }

        [Test]
        public void BeEmptyWhenCreated() {
            CollectionAssert.AreEqual(new int[0], new CircularList<int>());
        }

        [Test]
        public void CurrentNextPreviousEquala() {
            var cl = new CircularList<int>();
            cl.Add(0);
            cl.Add(1);
            cl.Add(2);

            Assert.AreEqual(2, cl.Previous);
            Assert.AreEqual(0, cl.Current);
            Assert.AreEqual(1, cl.Next);
        }

        [Test]
        public void MoveNext() {
            var cl = new CircularList<int>();
            cl.Add(0);
            cl.Add(1);
            cl.Add(2);

            Assert.AreEqual(2, cl.Previous);
            Assert.AreEqual(0, cl.Current);
            Assert.AreEqual(1, cl.Next);

            cl.MoveNext();

            Assert.AreEqual(0, cl.Previous);
            Assert.AreEqual(1, cl.Current);
            Assert.AreEqual(2, cl.Next);

            cl.MoveNext();

            Assert.AreEqual(1, cl.Previous);
            Assert.AreEqual(2, cl.Current);
            Assert.AreEqual(0, cl.Next);
        }

        [Test]
        public void MoveBack() {
            var cl = new CircularList<int>();
            cl.Add(0);
            cl.Add(1);
            cl.Add(2);

            Assert.AreEqual(2, cl.Previous);
            Assert.AreEqual(0, cl.Current);
            Assert.AreEqual(1, cl.Next);

            cl.MoveBack();

            Assert.AreEqual(1, cl.Previous);
            Assert.AreEqual(2, cl.Current);
            Assert.AreEqual(0, cl.Next);

            cl.MoveBack();

            Assert.AreEqual(0, cl.Previous);
            Assert.AreEqual(1, cl.Current);
            Assert.AreEqual(2, cl.Next);
        }
    }
}