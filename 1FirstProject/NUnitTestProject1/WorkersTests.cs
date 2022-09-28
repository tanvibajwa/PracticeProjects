using NUnit.Framework;
using HumanBeings;
using System;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void sorting()
        {
            int[] wages =  { 200, 456, 900, 500, 600, 30, 66, 80, 1000, 45 };
            int[] sorted_array = new int[] { 1000, 900, 600, 500, 456, 200, 80, 66, 45, 30 };
            wages = Worker.sort_wages(wages);
            Assert.That(Enumerable.SequenceEqual(wages, sorted_array));
            Assert.That(wages, Is.EqualTo(sorted_array));
        }
    }
}