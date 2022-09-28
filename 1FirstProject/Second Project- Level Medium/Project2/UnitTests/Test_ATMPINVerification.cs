using ConsoleApp1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    class Test_ATMPINVerification
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [TestCase("1234", ExpectedResult = true)]
        [TestCase("a234", ExpectedResult = false)]
        [TestCase("12345", ExpectedResult = false)]
        [TestCase("", ExpectedResult = false)]
        [TestCase("%234", ExpectedResult = false)]
        [TestCase("`234", ExpectedResult = false)]
        [TestCase("@234", ExpectedResult = false)]
        [TestCase("#234", ExpectedResult = false)]
        [TestCase("$234", ExpectedResult = false)]
        [TestCase("*234", ExpectedResult = false)]
        [TestCase("123457", ExpectedResult = true)]
        [TestCase("123412345", ExpectedResult = false)]
        public bool pin_validation_should_be_true(string input)
        {
            return MathHelpers.pin_validation(input);
        }
    }
}
