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

        [Test]
        public void Test4()
        {
            Assert.AreEqual(120, CalculateCombination.Calculate(10, 7));
        }

       

        [Test]
        [TestCase(12,12,11)]
        [TestCase(5005,15,9)]
        public void Test5And6(int result, int n, int k)
        {
            Assert.AreEqual(result, CalculateCombination.Calculate(n, k));
        }

        [Test]
        public void Test7_Throws() {
            Assert.Throws<ArgumentException>(() => CalculateCombination.Calculate(5, 10));
        }
    }
}