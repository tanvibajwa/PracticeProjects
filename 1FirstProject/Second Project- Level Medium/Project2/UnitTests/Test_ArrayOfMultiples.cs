using ConsoleApp1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    class Test_ArrayOfMultiples
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public static void should_be_equal()
        {
            var result = MathHelpers.array_of_multiples(7, 5);
            int[] arrayOfIntegers = new int[] { 7, 14, 21, 28, 35 };
            Assert.AreEqual(arrayOfIntegers, result);
        }
    }
}
