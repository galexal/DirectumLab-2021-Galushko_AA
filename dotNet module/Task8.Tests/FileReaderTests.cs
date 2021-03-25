using NUnit.Framework;
using System.IO;



namespace Task8.Tests
{
    public class FileReaderTests
    {
        [Test]
        public void DoesFileReaderWork()
        {
            string result = string.Empty;
            using (StreamWriter sw = new StreamWriter("test.txt", false, System.Text.Encoding.Default))
            {
                sw.WriteLine("test");
            }

            var reader = new FileReader("test.txt");
            foreach (var line in reader)
            {
                result += line.ToString();
            }

            var expected = "test";

            Assert.AreEqual(expected, result);
        }
    }
}
