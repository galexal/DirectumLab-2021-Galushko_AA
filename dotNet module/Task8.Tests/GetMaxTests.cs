using NUnit.Framework;


namespace Task8.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1,2,3,3)]
        [TestCase(5, 4, 5, 5)]
        [TestCase(10, 10, 0, 10)]
        public void GetMaxValue(int firstValue, int secondValue, int thirdValue, int result)
        {

            Assert.AreEqual(result, Program.GetMax(firstValue, secondValue, thirdValue));
        }
    }
}