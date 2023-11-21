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
    }
}