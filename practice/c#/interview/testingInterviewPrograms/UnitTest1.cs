using NUnit.Framework;
using interview;

namespace testingInterviewPrograms
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void findTheBomb()
        {
            Program prog = new Program();
            var result = prog.find_the_bomb("there's no bomb");
            var result2 = prog.find_the_bomb("nothing bro!");
            Assert.That(result == "Duck!!");
            Assert.That(result2 == "There is no bomb");
        }


        [Test]
        public void convert_to_string()
        {
            Program prog = new Program();
            object[] input = new object[] { 1, 2, "w" };
            var result = prog.parseToString(input);
        }

        [Test]
        public void largest_number()
        {
            Program prog = new Program();
            int[] arr1 = new int[] { 7, 1, 9, 3 };
            var result1 = prog.largestNumberInAnArray(arr1);
            Assert.That(result1 == 9);

            int[] arr2 = new int[] { 0, 1, 4, 55 };
            var result2 = prog.largestNumberInAnArray(arr2);
            Assert.That(result2 == 55);

            int[] arr3 = new int[] { 67, 9, 0, 7, 67 };
            var result3 = prog.largestNumberInAnArray(arr3);
            Assert.That(result3 == 67);
        }

        [Test]
        public void largest_numbers_group()
        {
            Program prog = new Program();
            int[][] arr1 = new int[][]
            {
                new int[] { 7, 1, 9, 3 },
                new int[] { 3, 5, 7, 10 }
            };
            var result1 = prog.largestNumbersInGroups(arr1);
            // Assert.That(result1 == 9);
        }
    }
}