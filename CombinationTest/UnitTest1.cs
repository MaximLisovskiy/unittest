using Combination;

namespace CombinationTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, CalculateCombination.Calculate(1, 1));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, CalculateCombination.Calculate(0, 0));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(10, CalculateCombination.Calculate(5, 2));
        }
     

    }
}