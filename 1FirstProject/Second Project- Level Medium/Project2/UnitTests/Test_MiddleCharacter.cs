using ConsoleApp1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    class Test_MiddleCharacter
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [TestCase("loop", ExpectedResult = "oo")]
        [TestCase("testing", ExpectedResult = "t")]
        [TestCase("middle", ExpectedResult = "dd")]
        [TestCase("A", ExpectedResult = "A")]
        [TestCase("inhabitant", ExpectedResult = "bi")]
        [TestCase("brown", ExpectedResult = "o")]
        [TestCase("pawn", ExpectedResult = "aw")]
        [TestCase("cabinet", ExpectedResult = "i")]
        [TestCase("fresh", ExpectedResult = "e")]
        [TestCase("shorts", ExpectedResult = "or")]
        public string middle_char_should_be_equal(string input)
        {
            return StringHelpers.get_middle_characters(input);
        }
    }
}
