using NUnit.Framework;
using System;

namespace Task8.Tests
{
    public class Tests
    {
        [TestCase(1, 2, 3, 3)]
        [TestCase(0.5, -0.17, 0, 0.5)]
        [TestCase("ab", "bcd", "e", "e")]
        public void GetMaxValue<T>(T firstValue, T secondValue, T thirdValue, T result) where T : IComparable
        {
            Assert.AreEqual(result, Program.GetMax(firstValue, secondValue, thirdValue));
        }
    }
}