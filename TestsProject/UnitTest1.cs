using MyDynamicArray;

namespace TestsProject
{
    public class DynamicArrayTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Count_Increase_CountIncreased()
        {
            //arrange
            var list = new DynamicArray();
            var expected = list.Count + 1;

            //act
            list.Add(5);
            var countChange = list.Count;

            // assert
            Assert.That(countChange, Is.EqualTo(expected));
        }
        [Test]
        public void Count_Empty_CountEqualZero()
        {
            //arrange
            var list = new DynamicArray();
            var expected = 0;

            //act
            var count = list.Count;

            // assert
            Assert.That(count, Is.EqualTo(expected));
        }
        [Test]
        public void Count_ShouldMatchNumberOfAddedElements_WhenMultipleElementsAdded()
        {
            //arrange
            var list = new DynamicArray();
            int expected = 3;

            //act
            list.Add(5);
            list.Add(4);
            list.Add(3);

            //assert
            Assert.That(expected, Is.EqualTo(list.Count));
        }
        [Test]
        public void Add_ShouldAddElementToList_WhenAddedOneElement()
        {
            //arrange
            var list = new DynamicArray();
            int expected = 5;

            //act
            list.Add(5);


            //assert
            Assert.That(list[0], Is.EqualTo(expected));
        }
        [Test]
        public void Add_ShouldAddElementRightly_WhenAddedSeveralElements()
        {
            DynamicArray dynamicArray = new DynamicArray();
            var expected = new int[3] { 5, 3, 2 };


            dynamicArray.Add(5);
            dynamicArray.Add(3);
            dynamicArray.Add(2);

            Assert.That(dynamicArray.Count, Is.EqualTo(expected.Length));
            Assert.That(dynamicArray[0], Is.EqualTo(expected[0]));
            Assert.That(dynamicArray[1], Is.EqualTo(expected[1]));
            Assert.That(dynamicArray[2], Is.EqualTo(expected[2]));
        }
        [Test]
        public void Add_ShouldResizeListThenAdd_WhenToAddHaveToResize()
        {
            DynamicArray dynamicArray = new DynamicArray();
            var expected = new int[5] { 1, 2, 3, 4, 5 };


            dynamicArray.Add(1);
            dynamicArray.Add(2);
            dynamicArray.Add(3);
            dynamicArray.Add(4);
            dynamicArray.Add(5);


            Assert.That(dynamicArray.Count, Is.EqualTo(expected.Length));
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(dynamicArray[i], Is.EqualTo(expected[i]));
            }

        }
        [Test]
        public void Insert_ShouldInsertElementFirst_WhenInsertIndexIsZero()
        {
            DynamicArray dynArray = new DynamicArray();
            var expected = new int[4] { 99, 1, 2, 3 };

            dynArray.Add(1);
            dynArray.Add(2);
            dynArray.Add(3);
            dynArray.Insert(0, 99);

            Assert.That(dynArray.Count, Is.EqualTo(expected.Length));
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(dynArray[i], Is.EqualTo(expected[i]));
            }
        }
        [Test]
        public void Insert_ShouldInsertElementInMiddle_WhenInsertInMiddle()
        {
            DynamicArray dynamicArray = new DynamicArray();
            var expected = new int[4] { 1, 2, 55, 3 };

            dynamicArray.Add(1);
            dynamicArray.Add(2);
            dynamicArray.Add(3);
            dynamicArray.Insert(2, 55);


            Assert.That(dynamicArray.Count, Is.EqualTo(expected.Length));
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(dynamicArray[i], Is.EqualTo(expected[i]));
            }
        }
        [Test]
        public void Insert_ShouldInsertElementInEnd_WhenInsertInEnd()
        {
            DynamicArray dynamicArray = new DynamicArray();
            var expected = new int[4] { 1, 2, 3, 55 };

            dynamicArray.Add(1);
            dynamicArray.Add(2);
            dynamicArray.Add(3);
            dynamicArray.Insert(3, 55);


            Assert.That(dynamicArray.Count, Is.EqualTo(expected.Length));
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(dynamicArray[i], Is.EqualTo(expected[i]));
            }
        }
        [Test]
        public void Insert_ShoulInsertFirst_WhenInsertWithIndexZero()
        {
            DynamicArray dynamicArray = new DynamicArray();
            var expected = new int[1] { 67, };


            dynamicArray.Insert(0, 67);

            Assert.That(dynamicArray.Count, Is.EqualTo(expected.Length));

            Assert.That(dynamicArray[0], Is.EqualTo(expected[0]));
        }
        [Test]
        public void Insert_ShoouldThrowException_WhenIndexIsLowerThatCount()
        {
            DynamicArray dynamicArray = new DynamicArray();


            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                dynamicArray.Insert(-1, 99);
            });


        }
        [Test]
        public void Insert_ShouldThrowException_WhenIndexIsBiggerThanCount()
        {
            DynamicArray dynamicArray = new DynamicArray();




            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                dynamicArray.Insert(100, 100);
            });
        }
        [Test]
        public void Remove_ShouldRemoveElement_WhenRemoveElement()
        {
            DynamicArray dynamicArray = new DynamicArray();
            var expected = new int[2] { 1, 3 };


            dynamicArray.Add(1);
            dynamicArray.Add(2);
            dynamicArray.Add(3);
            dynamicArray.Remove(2);

            Assert.That(dynamicArray.Count, Is.EqualTo(expected.Length));
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(dynamicArray[i], Is.EqualTo(expected[i]));
            }
        }
        [Test]
        public void Remove_ShouldNotRemove_WhenElementIsNotOnTheList()
        {
            DynamicArray dynamicArray = new DynamicArray();
            var expected = new int[3] { 1, 2, 3 };


            dynamicArray.Add(1);
            dynamicArray.Add(2);
            dynamicArray.Add(3);
            dynamicArray.Remove(33);

            Assert.That(dynamicArray.Count, Is.EqualTo(expected.Length));
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(dynamicArray[i], Is.EqualTo(expected[i]));
            }
        }
        [Test]
        public void Remove_ShouldRemoveOnlyOne_WhenRemoveElementThatHaveSameInArray()
        {
            DynamicArray dynamicArray = new DynamicArray();
            var expected = new int[3] { 5, 4, 5 };

            dynamicArray.Add(4);
            dynamicArray.Add(5);
            dynamicArray.Add(4);
            dynamicArray.Add(5);

            dynamicArray.Remove(4);

            Assert.That(dynamicArray.Count, Is.EqualTo(expected.Length));
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(dynamicArray[i], Is.EqualTo(expected[i]));
            }
        }
        [Test]
        public void RemoveAt_ShouldThrowException_WhenIndexIsBiggerThanCount()
        {
            DynamicArray dynamicArray = new DynamicArray();




            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                dynamicArray.RemoveAt(100);
            });
        }
        [Test]
        public void RemoveAt_ShouldThrowException_WhenIndexIsLowerThanCount()
        {
            DynamicArray dynamicArray = new DynamicArray();


            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                dynamicArray.RemoveAt(-1);
            });
        }
        [Test]
        public void RemoveAt_ShouldRemoveElementAtFirst_WhenRemoveIndexIsZero()
        {
            DynamicArray dynArray = new DynamicArray();
            var expected = new int[3] { 1, 2, 3 };

            dynArray.Add(67);
            dynArray.Add(1);
            dynArray.Add(2);
            dynArray.Add(3);
            dynArray.RemoveAt(0);

            Assert.That(dynArray.Count, Is.EqualTo(expected.Length));
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(dynArray[i], Is.EqualTo(expected[i]));
            }
        }
        [Test]
        public void RemoveAt_ShouldRemoveElementAtMiddle_WhenRemoveInMiddle()
        {
            DynamicArray dynamicArray = new DynamicArray();
            var expected = new int[3] { 1, 2, 3 };

            dynamicArray.Add(1);
            dynamicArray.Add(2);
            dynamicArray.Add(55);
            dynamicArray.Add(3);
            dynamicArray.RemoveAt(2);


            Assert.That(dynamicArray.Count, Is.EqualTo(expected.Length));
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(dynamicArray[i], Is.EqualTo(expected[i]));
            }
        }
        [Test]
        public void RemoveAt_ShouldRemoveElementAtEnd_WhenRemoveInEnd()
        {
            DynamicArray dynamicArray = new DynamicArray();
            var expected = new int[3] { 1, 2, 3 };

            dynamicArray.Add(1);
            dynamicArray.Add(2);
            dynamicArray.Add(3);
            dynamicArray.Add(55);
            dynamicArray.RemoveAt(3);


            Assert.That(dynamicArray.Count, Is.EqualTo(expected.Length));
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(dynamicArray[i], Is.EqualTo(expected[i]));
            }
        }
        [Test]
        public void AddRange_ShouldAddAllElements_WhenArrayIsEmpty()
        {
            DynamicArray dynamicArray = new DynamicArray();
            var expected = new int[3] { 1, 2, 3 };


            dynamicArray.AddRange(new int[3] { 1, 2, 3 });

            Assert.That(dynamicArray.Count, Is.EqualTo(expected.Length));
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(dynamicArray[i], Is.EqualTo(expected[i]));
            }
        }

        [Test]
        public void AddRange_ShouldAddElementToExisted_WhenArrayHasElements()
        {
            DynamicArray dynamicArray = new DynamicArray();
            var expected = new int[4] { 1, 2, 3, 4 };


            dynamicArray.Add(1);
            dynamicArray.Add(2);
            dynamicArray.AddRange(new int[2] { 3, 4 });

            Assert.That(dynamicArray.Count, Is.EqualTo(expected.Length));
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(dynamicArray[i], Is.EqualTo(expected[i]));
            }
        }
        [Test]
        public void AddRange_ShouldAddEmptyMassive_WhenMassiveHasElements()
        {
            DynamicArray dynamicArray = new DynamicArray();
            var expected = new int[4] { 1, 2, 3, 4 };


            dynamicArray.Add(1);
            dynamicArray.Add(2);
            dynamicArray.Add(3);
            dynamicArray.Add(4);
            dynamicArray.AddRange(new int[0] { });

            Assert.That(dynamicArray.Count, Is.EqualTo(expected.Length));
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(dynamicArray[i], Is.EqualTo(expected[i]));
            }
        }
        [Test]
        public void AddRange_ShouldAddRangeAndIncreaseCapacity_WhenElementsAreMany()
        {
            DynamicArray dynamicArray = new DynamicArray();
            var expected = new int[5] { 1, 2, 3, 4, 5 };


            dynamicArray.AddRange(new int[5] { 1, 2, 3, 4, 5 });

            Assert.That(dynamicArray.Count, Is.EqualTo(expected.Length));
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(dynamicArray[i], Is.EqualTo(expected[i]));
            }
        }
        [Test]
        public void Clear_ShouldClearMasive_WhenMassiveHasElements()
        {
            DynamicArray dynamicArray = new DynamicArray();
            var expected = new int[0];

            dynamicArray.Add(1);
            dynamicArray.Add(2);
            dynamicArray.Add(3);
            dynamicArray.Add(4);

            dynamicArray.Clear();

            Assert.That(dynamicArray.Count, Is.EqualTo(expected.Length));
        }
    }
}
