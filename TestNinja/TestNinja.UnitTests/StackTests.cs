using System;
using System.Text;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_WhenCalled_ThrowsArgException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_WhenCalled_AddTheObjectToTheStack()
        {
            var stack = new Stack<string>();

            stack.Push("a");
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_EmptyStack_ReturnsZero()
        {
            var stack = new Stack<string>();

            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_EmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackWithAFewObject_ReturnsObjectOnTheTop()
        {
            var stack = new Stack<string>();

            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            Assert.That(() => stack.Pop(), Is.EqualTo("c"));
        }

        [Test]
        public void Pop_StackWithAFewObject_RemoveObjectFromStack()
        {
            var stack = new Stack<string>();

            stack.Push("a");
            stack.Push("b");

            stack.Pop();

            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Peek_EmptyStack_ReturnInvalidOperationException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackWithObject_ReturnObjectFromTheStack()
        {
            var stack = new Stack<string>();

            stack.Push("a");
            stack.Push("b");

            var result = stack.Peek();

            Assert.That(result, Is.EqualTo("b"));
        }

        [Test]
        public void Peek_StackWithObject_NoRemoveObjectIfPeek()
        {
            var stack = new Stack<string>();

            stack.Push("a");
            stack.Push("b");

            stack.Peek();

            Assert.That(() => stack.Count, Is.EqualTo(2));
        }
    }
}
