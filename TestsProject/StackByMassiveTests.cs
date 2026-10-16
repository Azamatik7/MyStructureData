namespace TestsProject
{
    using MyStackByMassive;

    public class StackByMassiveTests
    {
        [Test]
        public void Count_Increase_CountIncreased()
        {
            //arrange
            var stack = new MyStackByMassive();
            var expected = stack.Count + 1;

            //act
            stack.Push(5);
            var countChange = stack.Count;

            // assert
            Assert.That(countChange, Is.EqualTo(expected));
        }
        [Test]
        public void Count_Empty_CountEqualZero()
        {
            //arrange
            var stack = new MyStackByMassive();
            var expected = 0;

            //act
            var count = stack.Count;

            // assert
            Assert.That(count, Is.EqualTo(expected));
        }
        [Test]
        public void Count_ShouldMatchNumberOfPushedElements_WhenMultipleElementsPushed()
        {
            //arrange
            var stack = new MyStackByMassive();
            int expected = 3;

            //act
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);

            //assert
            Assert.That( stack.Count, Is.EqualTo(expected));
        }
        [Test]
        public void IsEmpty_ShouldDefineEmptiness_WhenStackIsEmptyAndNot()
        {
            var stackEmpty = new MyStackByMassive();
            

            Assert.That(stackEmpty.IsEmpty(), Is.True);
        }
        [Test]
        public void IsEmpty_ShouldDefineNotEmptiness_WhenStackIsEmptyAndNot()
        {
            var stackNotEmpty = new MyStackByMassive();

            stackNotEmpty.Push(5);

            Assert.That(stackNotEmpty.IsEmpty(), Is.False);
        }
        [Test]
        public void Push_ShouldPushElement_WhenStackIsEmpty()
        {
            var stack = new MyStackByMassive();
            var expected = new int[1] { 4 };


            stack.Push(4);

            Assert.That(stack.Count, Is.EqualTo(expected.Length));

            Assert.That(stack.Peek(), Is.EqualTo(expected[0]));
        }
        [Test]
        public void Push_ShouldPushAllElements_WhenSeveralElementsPushed()
        {
            var stack = new MyStackByMassive();
            var expected = new int[3] { 3, 2, 1 };


            stack.Push(1);
            stack.Push(2);
            stack.Push(3);


            Assert.That(stack.Count, Is.EqualTo(expected.Length));

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(stack.Pop(), Is.EqualTo(expected[i]));
            }
        }
        [Test]
        public void Pop_ShouldPopOnlyElement_WhenStackContainsOnlyElement()
        {
            var stack = new MyStackByMassive();
            var expectedCount = 0;
            var expectedPopped = 1;

            stack.Push(1);
            var popped = stack.Pop();

            Assert.That(popped, Is.EqualTo(expectedPopped));
            Assert.That(stack.Count, Is.EqualTo(expectedCount));
        }
        [Test]
        public void Pop_ShouldPopLastPushedElement_WhenStackContainsElements()
        {
            var stack = new MyStackByMassive();
            var expected = new int[3] { 3, 2, 1 };
            var expectedPopped = 4;

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            var popped = stack.Pop();

            Assert.That(stack.Count, Is.EqualTo(expected.Length));
            Assert.That(popped, Is.EqualTo(expectedPopped));

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(stack.Pop(), Is.EqualTo(expected[i]));
            }

        }

        [Test]
        public void Pop_ShouldThrowException_WhenStackIsEmpty()
        {
            var stack = new MyStackByMassive();

            Assert.Throws<Exception>(() =>
            {
                stack.Pop();
            });
        }
        [Test]
        public void Peek_ShouldThrowException_WhenStackIsEmpty()
        {
            var stack = new MyStackByMassive();

            Assert.Throws<Exception>(() =>
            {
                stack.Peek();
            });
        }

        [Test]
        public void Peek_ShouldPeekElement_WhenStackContainsElements()
        {
            var stack = new MyStackByMassive();
            var expected = new int[4] { 4, 3, 2, 1 };
            var expectedPeek = 4;

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            var peek = stack.Peek();

            Assert.That(stack.Count, Is.EqualTo(expected.Length));
            Assert.That(peek, Is.EqualTo(expectedPeek));

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(stack.Pop(), Is.EqualTo(expected[i]));
            }
        }
        [Test]
        public void Clear_ShouldClearStack_WhenStackContainsElements()
        {
            var stack = new MyStackByMassive();
            var expected = 0;

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Clear();

            Assert.That(stack.Count, Is.EqualTo(expected));
        }
        [Test]
        public void Increase_ShouldIncreaseStackAndReWriteElementsRightly_WhenElementsAreMoreThanFour()
        {
            var stack = new MyStackByMassive();
            var expected = new int[5] { 5, 4, 3, 2, 1, };

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Assert.That(stack.Count, Is.EqualTo(expected.Length));

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(stack.Pop(), Is.EqualTo(expected[i]));
            }

        }
    }
}
