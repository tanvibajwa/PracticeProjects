using ConsoleApp1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    class Test_MaskifytheString
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [TestCase("11232434", ExpectedResult = "####2434")]
        [TestCase("4556364607935616", ExpectedResult = "############5616")]
        [TestCase("64607935616", ExpectedResult = "#######5616")]
        [TestCase("1", ExpectedResult = "1")]
        [TestCase("", ExpectedResult = "")]
        [TestCase("tBy>L/cMe+?<j:6n;C~H", ExpectedResult = "################;C~H")]
        [TestCase("12", ExpectedResult = "12")]
        [TestCase("8Ikhlf6yoxPOwi5cB014eWbRumj7vJ", ExpectedResult = "##########################j7vJ")]
        [TestCase("123", ExpectedResult = "123")]
        [TestCase(")E$aCU=e\"_", ExpectedResult = "######=e\"_")]
        [TestCase("2673951408", ExpectedResult = "######1408")]
        [TestCase("1234", ExpectedResult = "1234")]
        public string masked_result_should_be_equal(string input)
        {
            return StringHelpers.maskify(input);
        }
    }
}