using NUnit.Framework;

namespace Task12.Tests
{
    public class ConfiReaderTests
    {
        [Test]
        public void DoesConfigReaderWork()
        {
            var actual = ConfigReader.GetSettings();
            var expected = "���: Name\n��������: value";
            Assert.AreEqual(expected, actual);
        }
    }
}