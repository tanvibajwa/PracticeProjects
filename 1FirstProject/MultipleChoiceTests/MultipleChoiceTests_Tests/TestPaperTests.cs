using NUnit.Framework;
using MultipleChoiceTests;

namespace MultipleChoiceTests_Tests
{
    public class TestPaperTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void should_say_No_Tests_Taken_when_tests_not_taken()
        {
            Student student1 = new Student();

            Assert.AreEqual(student1.TestsTaken, new string[] { "No tests taken" });
        }

        [Test]
        public void should_return_tests_result_of_a_student()
        {
            TestPaper paper1 = new TestPaper("Maths", new string[] { "1A", "1B", "2C", "3D", "AE" }, "60%");
            TestPaper paper2 = new TestPaper("Chemistry", new string[] { "1C", "2C", "3D", "4A" }, "75%");

            Student student1 = new Student();
            student1.TakeTest(paper1, new string[] { "1A", "2D", "3D", "4A", "5A" });

            student1.TakeTest(paper2, new string[] { "1C", "2C", "3D", "4A" });

            Assert.That(student1.TestsTaken[0], Is.EqualTo("Maths: Failed! (20%)"));
            Assert.That(student1.TestsTaken[1], Is.EqualTo("Chemistry: Passed! (100%)"));
            Assert.AreEqual(student1.TestsTaken, new string[] { "Maths: Failed! (20%)", "Chemistry: Passed! (100%)"});

        }

    }
}