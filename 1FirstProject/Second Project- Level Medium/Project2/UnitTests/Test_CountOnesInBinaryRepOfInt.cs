using ConsoleApp1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    class Test_CountOnesInBinaryRepOfInt
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [TestCase(8, ExpectedResult ="1000")]
        [Ignore("TODO")]
        public string binary_equivalent(int input)
        {
            return MathHelpers.convert_to_binary(input);           
        }

        [Test]
        [Ignore("TODO")]
        [TestCase(12, ExpectedResult = 2)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(100, ExpectedResult = 3)]
        [TestCase(101, ExpectedResult = 4)]
        [TestCase(999, ExpectedResult = 8)]
        [TestCase(123456789, ExpectedResult = 16)]
        [TestCase(1234567890, ExpectedResult = 12)]
        public int number_of_ones_should_be_equal(int input)
        {
            return MathHelpers.count_ones(input);
        }
    }
}
