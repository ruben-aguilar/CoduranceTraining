using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercise1
{
    [TestFixture]
    class StackShould
    {
        private MyStack stack;

        [SetUp]
        public void SetUp()
        {
            stack = new MyStack();
        }

        [Test]
        public void throws_when_popped_empty()
        {

            Assert.Throws<EmptyException>(() => { stack.pop(); });
        }

        [Test]
        public void pops_last_pushed_object()
        {
            Object objectToPush = new Object();
            stack.push(objectToPush);

            Object popedObject = stack.pop();

            Assert.AreEqual(objectToPush, popedObject);
        }

        [Test]
        public void pops_pushed_objects_in_reversed_order()
        {
            Object firstPushedObject = new Object();
            stack.push(firstPushedObject);
            Object secondPushedObject = new Object();
            stack.push(secondPushedObject);

            var firstPopedObject = stack.pop();
            var secondPopedObject = stack.pop();

            Assert.AreEqual(secondPushedObject, firstPopedObject);
            Assert.AreEqual(firstPushedObject, secondPopedObject);
        }
    }
}
