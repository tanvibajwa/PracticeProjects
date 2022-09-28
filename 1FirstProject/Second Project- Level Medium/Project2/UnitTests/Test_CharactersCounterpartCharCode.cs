using ConsoleApp1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    class Test_CharactersCounterpartCharCode
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void char_should_be_reversed()
        {
            char result = StringHelpers.reverse_case('A');
            char expected_output = 'a';
            Assert.That(result, Is.EqualTo(expected_output));
        }

        [Test]
        [TestCase('A', ExpectedResult = 97)]
        [TestCase('a', ExpectedResult = 65)]
        [TestCase('\0', ExpectedResult = 0)]
        public int char_code_should_be_equal(char input)
        {
            return StringHelpers.char_counterpart_char_code(input);
        }

    }
}
