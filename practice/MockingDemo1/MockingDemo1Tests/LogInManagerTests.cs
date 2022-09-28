using NUnit.Framework;

using MockingDemo1;

namespace MockingDemo1Tests
{
    [TestFixture]
    public class Tests
    {
        LogInManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new LogInManager(string.Empty);
        }

        [Test]
        public void test_func()
        {
            Assert.Fail();
        }

        [Test]
        public void should_return_false_if_id_doesnt_match()
        {
            manager.ExpectedUserID = "tanvi";

            var result = manager.CheckCredentials();

            Assert.IsFalse(result);
        }

        [Test]
        public void should_return_true_if_id_matches()
        {

        }

        [Test]
        public void should_return_false_if_barcode_scanner_fails_to_connect()
        {

        }
    }
}