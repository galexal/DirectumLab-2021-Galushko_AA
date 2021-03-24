using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task8;



namespace Task8.Tests
{
    class FileReaderTests
    {
        [Test]
        public void DoesFileReaderWork()
        {
            using (var logFile = new FileStream("test.txt", FileMode.Append))
            {
                var logWriter = new StreamWriter(logFile);
                logWriter.WriteLine("test"); 
            }

            var reader = new FileReader("test.txt");
            foreach (var line in reader)
            {
                Console.WriteLine(line);
            }
            Assert.Pass();
        }
    }
}
