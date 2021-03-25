using NUnit.Framework;

namespace Task12.Tests
{
    public class ConfiReaderTests
    {
        [Test]
        public void DoesConfigReaderWork()
        {
            var actual = ConfigReader.GetSettings();
            var expected = "Имя: Name\nЗначение: value";
            Assert.AreEqual(expected, actual);
        }
    }
}