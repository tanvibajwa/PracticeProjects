using NUnit.Framework;
using ReadFile_ManipulateData_CreateFile;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    class DataManipulationTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public static void should_return_data_in_ascending_order()
        {
            //Arrangel
            var collection = new List<StockPriceEntry>() 
            { 
              //  new StockPriceEntry("tsla", 100.60f, DateTime.Parse("10:00")), 
                new StockPriceEntry() { Name = "tsla", Price=200.60f, Time = DateTime.Parse("11:00") }, 
                new StockPriceEntry() { Name = "tsla", Price=120.90f, Time = DateTime.Parse("12:00")}, 
                new StockPriceEntry() { Name = "tsla", Price=150, Time = DateTime.Parse("13:00")}, 
                new StockPriceEntry() { Name = "tsla", Price=180, Time = DateTime.Parse("14:00")}
            };
          
            //Act
            DataManipulation.SortEntriesByAscendingPrice(collection);

            //Assert
            Assert.That(collection[0].Price, Is.EqualTo(100.60f));
            Assert.That(collection[0].Time, Is.EqualTo(DateTime.Parse("10:00")));
            Assert.That(collection[0].Name, Is.EqualTo("tsla"));
            Assert.That(collection[1].Price, Is.EqualTo(120.90f));
            Assert.That(collection[1].Time, Is.EqualTo(DateTime.Parse("12:00")));
            Assert.That(collection[1].Name, Is.EqualTo("tsla"));
            Assert.That(collection[2].Price, Is.EqualTo(150.0f));
            Assert.That(collection[2].Time, Is.EqualTo(DateTime.Parse("13:00")));
            Assert.That(collection[2].Name, Is.EqualTo("tsla"));
            Assert.That(collection[3].Price, Is.EqualTo(180.0f));
            Assert.That(collection[3].Time, Is.EqualTo(DateTime.Parse("14:00")));
            Assert.That(collection[3].Name, Is.EqualTo("tsla"));
            Assert.That(collection[4].Price, Is.EqualTo(200.60f));
            Assert.That(collection[4].Time, Is.EqualTo(DateTime.Parse("11:00")));
            Assert.That(collection[4].Name, Is.EqualTo("tsla"));
        }

        [Test]
        public static void should_have_percent_deviation_column_in_list()
        {
            //Arrangel
            var collection = new List<StockPriceEntry>()
            {
               // new StockPriceEntry("tsla", 100.60f, DateTime.Parse("10:00")),
                new StockPriceEntry() { Name = "tsla", Price=120.90f, Time = DateTime.Parse("12:00")},
                new StockPriceEntry() { Name = "tsla", Price=150, Time = DateTime.Parse("13:00")},
                new StockPriceEntry() { Name = "tsla", Price=180, Time = DateTime.Parse("14:00")},
                new StockPriceEntry() { Name = "tsla", Price=200.60f, Time = DateTime.Parse("11:00") }
            };

            //Act
            DataManipulation.CalculateAndAddPercentageDifferenceAttribute(collection);

            //Assert
            Assert.That(collection[0].PercentDifference, Is.EqualTo(99.40f));
            Assert.That(collection[1].PercentDifference, Is.EqualTo(65.92f));
            Assert.That(collection[2].PercentDifference, Is.EqualTo(33.73f));
            Assert.That(collection[3].PercentDifference, Is.EqualTo(11.11f));
            Assert.That(collection[4].PercentDifference, Is.EqualTo(0));

        }
    }
}
