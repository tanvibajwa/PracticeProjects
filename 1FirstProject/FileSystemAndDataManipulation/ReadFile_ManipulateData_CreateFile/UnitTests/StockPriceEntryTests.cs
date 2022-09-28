using NUnit.Framework;using ReadFile_ManipulateData_CreateFile;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    public class StockPriceEntry_ParsingTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void should_be_true_if_parsing_is_successful()
        {
            var result = StockPriceEntry.TryParseFromCSVEntry("10:00,tsla,67.90", out StockPriceEntry entry);
            Assert.That(result, Is.EqualTo(true));
            Assert.That(entry.Name, Is.EqualTo("tsla"));
            Assert.That(entry.Price, Is.EqualTo(67.90f));
            Assert.That(entry.Time, Is.EqualTo(DateTime.Parse("10:00")));

            result = StockPriceEntry.TryParseFromCSVEntry("jdkhoeow,tsla,67.90", out StockPriceEntry _);
            Assert.That(result, Is.EqualTo(false));
            
            result = StockPriceEntry.TryParseFromCSVEntry("10:00,tsla,dsdqw", out StockPriceEntry _);
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void should_return_parsed_data()
        {
            //ParseData.parse_data(@"C:\Users\tsingh\Downloads\stock-data2.csv");
        }

        [Test]
        public static void should_return_string_data()
        {
            //Arrangel
            var collection = new List<StockPriceEntry>()
            {
                new StockPriceEntry("tsla", 100.60f, DateTime.Parse("10:00"),99.40f),
                new StockPriceEntry() { Name = "tsla", Price=120.90f, Time = DateTime.Parse("12:00"), PercentDifference = 65.92f},
                new StockPriceEntry() { Name = "tsla", Price=150, Time = DateTime.Parse("13:00"), PercentDifference = 33.73f},
                new StockPriceEntry() { Name = "tsla", Price=180, Time = DateTime.Parse("14:00"), PercentDifference = 11.11f},
                new StockPriceEntry() { Name = "tsla", Price=200.60f, Time = DateTime.Parse("11:00") , PercentDifference = 0f}
            };

            //Act
            StockPriceEntry.CollectionToStringCSV(collection);

            //Assert
            

        }
    }
}
