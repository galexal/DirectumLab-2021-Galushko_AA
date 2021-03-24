using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Tests
{
    class LoggerTests
    {
        [Test]
        public void DoesLoggerWork()
        {
            using (Logger logger = new Logger("test.txt"))
            {
                logger.WriteString("test");
            }
            Assert.Pass();
        }
    }
}
