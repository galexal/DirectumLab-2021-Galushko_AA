using NUnit.Framework;
using System.IO;

namespace Task4.Tests
{
    public class LoggerTests
    {
        [Test]
        public void DoesLoggerWork()
        {
            using (Logger logger = new Logger("test.txt"))
            {
                logger.WriteString("test");
            }

            string result;
            using (StreamReader sr = new StreamReader("test.txt"))
            {
                result = sr.ReadLine();
            }

            Assert.AreEqual("test", result);
        }
    }
}
