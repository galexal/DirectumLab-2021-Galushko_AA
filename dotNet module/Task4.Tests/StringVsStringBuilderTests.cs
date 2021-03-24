using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Tests
{
    class StringVsStringBuilderTests
    {
        [Test]
        public void StringBuilderIsFasterThanString()
        {
            var watch = new Stopwatch();
            watch.Start();
            StringVsStringBuilder.StringConcatenation();
            watch.Stop();
            var stringResult = watch.ElapsedMilliseconds;
            watch.Reset();
            watch.Start();
            StringVsStringBuilder.StringBuilderConcatenation();
            watch.Stop();
            var stringBuilderResult = watch.ElapsedMilliseconds;
            Assert.AreEqual(true, stringResult > stringBuilderResult);
        }
    }
}
