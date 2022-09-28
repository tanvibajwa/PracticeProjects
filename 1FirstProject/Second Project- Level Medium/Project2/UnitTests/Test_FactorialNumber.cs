using ConsoleApp1;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace UnitTests
{
    class Test_FactorialNumber
    {
        [SetUp]

        public void Setup()
        {

        }

        [Test]
        [TestCase(6, ExpectedResult = 720)]
        [TestCase(0, ExpectedResult = 1)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(10, ExpectedResult = 3628800)]
        [TestCase(-3, ExpectedResult = 0)]
        public static long factorial_result_should_match_expected_output(int number)
        {
            return MathHelpers.factorial(number);
        }
    }
}
