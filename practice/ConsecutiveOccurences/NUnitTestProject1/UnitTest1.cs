using NUnit.Framework;
using ConsoleApp1;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void testWithMaxOccurenceAtTheEnd()
        {
            HelperMethods pr = new HelperMethods();
            var number = pr.MaxConsecutiveOccurences(new int[] { 1, 2, 3, 3, 3, 7, 7, 7, 7 });
            Assert.That(number == 7);
        }

        [Test]
        public void testWithMaxOccurenceInTheMiddle()
        {
            HelperMethods pr = new HelperMethods();
            var number = pr.MaxConsecutiveOccurences(new int[] { 1, 2, 3, 3, 3, 7, 7 });
            Assert.That(number == 3);
        }

        [Test]
        public void testWithNullInput()
        {
            HelperMethods pr = new HelperMethods();
            var number = pr.MaxConsecutiveOccurences(null);
            Assert.That(number == 0);
        }

        [Test]
        public void testWithArrayLengthZero()
        {
            HelperMethods pr = new HelperMethods();
            var number = pr.MaxConsecutiveOccurences(new int[0]);
            Assert.That(number == 0);
        }

        [Test]
        public void testWithSingleNumberSet()
        {
            HelperMethods pr = new HelperMethods();
            var number = pr.MaxConsecutiveOccurences(new int[] { 1, 1, 1, 1 });
            Assert.That(number == 1);
        }

        [Test]
        public void testWithMaxOccurenceInTheBegining()
        {
            HelperMethods pr = new HelperMethods();
            var number = pr.MaxConsecutiveOccurences(new int[] { 1, 1, 1, 1, 9, 5, 5, 5 });
            Assert.That(number == 1);
        }

        [Test]
        public void testWith2MaxOccurences()
        {
            HelperMethods pr = new HelperMethods();
            var number = pr.MaxConsecutiveOccurences(new int[] { 1, 1, 1, 1, 9, 9, 9, 9 });
            Assert.That(number == 1);
        }

        [Test]
        public void shouldReturn2Numbers()
        {
            HelperMethods pr = new HelperMethods();
            var number = pr.ListOfAllMaximumConsecutiveOccuringNumbers(new int[] { 1, 1, 1, 1, 9, 9, 9, 9, 1, 9, 9, 1, 1, 9, 1 });

            Assert.That(number.Count, Is.EqualTo(2));
            Assert.That(number[0], Is.EqualTo(1));
            Assert.That(number[1], Is.EqualTo(9));
        }

        [Test]
        public void shouldReturn3Numbers()
        {
            HelperMethods pr = new HelperMethods();
            var number = pr.ListOfAllMaximumConsecutiveOccuringNumbers(new int[] { 1, 1, 2, 9, 9, 7, 6, 6 });
            Assert.That(number.Count, Is.EqualTo(3));
            Assert.That(number[0], Is.EqualTo(1));
            Assert.That(number[1], Is.EqualTo(9));
            Assert.That(number[2], Is.EqualTo(6));
        }

        [Test]
        public void shoudlReturnSingleNumber()
        {
            HelperMethods pr = new HelperMethods();
            var number = pr.ListOfAllMaximumConsecutiveOccuringNumbers(new int[] { 1, 1, 1, 1 });
            Assert.That(number.Count, Is.EqualTo(1));
            Assert.That(number[0], Is.EqualTo(1));
        }

        [Test]
        public void shouldReturnMaxOccurence()
        {
            HelperMethods pr = new HelperMethods();

            var number = pr.ListOfAllMaximumConsecutiveOccuringNumbers(new int[] { 1, 1, 1, 1, 9, 5, 5, 5 });
            Assert.That(number.Count, Is.EqualTo(1));
            Assert.That(number[0], Is.EqualTo(1));
        }

        [Test]
        public void shouldPutMaxOccuringNumbersInAFile()
        {

        }
    }
}