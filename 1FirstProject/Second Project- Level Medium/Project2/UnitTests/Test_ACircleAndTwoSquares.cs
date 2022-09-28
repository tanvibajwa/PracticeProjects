using NUnit.Framework;
using ConsoleApp1;
using System.Reflection.PortableExecutable;
using System;

namespace UnitTests
{
    public class when_calculating_areas
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void should_return_correct_result_for_square()
        {
            var result = MathHelpers.area_of_square(10);
            Assert.That(result, Is.EqualTo(100));
        }

        [Test]
        public void should_return_correct_result_for_triangle()
        {
            var result = MathHelpers.side_of_right_angled_triangle(9);
            Assert.That(result, Is.EqualTo(6.36).Within(0.01));
        }

        [Test]
        public void should_return_correct_difference()
        {
            var result = MathHelpers.square_area_difference(5);
            Assert.That(result, Is.EqualTo(50).Within(0.1));
        }

    }
}