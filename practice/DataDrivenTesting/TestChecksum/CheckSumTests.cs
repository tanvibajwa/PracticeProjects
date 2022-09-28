using System.Collections.Generic;

using NUnit.Framework;
using DataDrivenTesting;

namespace TestChecksum
{
    public interface ITestDataSource
    {
        public List<int[]> GetIntDataSet();
    }

    public class CSVDataSource : ITestDataSource
    {
        public List<int[]> GetIntDataSet()
        {
            var filedata = new Program();
            var fileDataInString = filedata.ReadFileData(@"../../../../DataSource/input_output_checksum.txt");

            return filedata.ConvertTextToNumbersData(fileDataInString);
        }

        public static List<int[]> GetIntegerDataSet() //wrapper method, not doing any transformation. used becuase a static method was required by one of the attributes
        {
            return new CSVDataSource().GetIntDataSet();
        }
    }

    public class Tests
    {
        ITestDataSource data_source;


        //public Tests(ITestDataSource data_source)
        //{

        //}

        [SetUp]
        public void Setup()
        {
            data_source = new CSVDataSource();
        }

        [Test]
        public void VerifyChecksumForAnArray()
        {
            var checksum = new Program();
            int[] set1 = new int[] { 1, 2, 3, 4 };
            var result = checksum.CalculateChecksum(set1);
            Assert.That(result == -11);
        }

        [Test]
        public void VerifyChecksumUsingDataFromFile()
        {
            var fileDataNumberSets = data_source.GetIntDataSet();
            var program = new Program();

            foreach (int[] eachSetOfNumbers in fileDataNumberSets)
            {
                var result = program.CalculateChecksum(eachSetOfNumbers[0..(eachSetOfNumbers.Length - 1)]);
                var output = eachSetOfNumbers[eachSetOfNumbers.Length - 1];
                Assert.AreEqual(result, output);
            }
        }

        [TestCaseSource(typeof(CSVDataSource), nameof(CSVDataSource.GetIntegerDataSet))]
        public void VerifyChecksumUsingAttributes1(int[] eachSetOfNumbers)
        {
            var program = new Program();

            var result = program.CalculateChecksum(eachSetOfNumbers[0..(eachSetOfNumbers.Length-1)]);
            var output = eachSetOfNumbers[eachSetOfNumbers.Length - 1];
            Assert.AreEqual(result, output);
        }

        [TestCaseSource(nameof(CSVDataSource.GetIntDataSet), new object[] { @"../../../../DataSource/input_output_checksum.txt" })]
        public void VerifyChecksumUsingAttributes(int[] eachSetOfNumbers)
        {
            var program = new Program();

            var result = program.CalculateChecksum(eachSetOfNumbers[0..(eachSetOfNumbers.Length - 1)]);
            var output = eachSetOfNumbers[eachSetOfNumbers.Length - 1];
            Assert.AreEqual(result, output);
        }
    }
}