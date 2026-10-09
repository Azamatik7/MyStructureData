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
            var expected = 1;

            //act
            var count = list.Count;
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
        

    }
}
