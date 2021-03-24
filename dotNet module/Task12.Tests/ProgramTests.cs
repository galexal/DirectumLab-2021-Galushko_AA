using NUnit.Framework;
using System;
using System.Reflection;
using static Task12.Program;

namespace Task12.Tests
{
    public class ProgramTests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void DoesConfigReaderWork ()
        {
            ConfigReader.PrintSettings();
            Assert.Pass();
        }
    }
}