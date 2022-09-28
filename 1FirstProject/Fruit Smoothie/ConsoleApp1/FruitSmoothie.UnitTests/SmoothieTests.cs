using NUnit.Framework;

namespace FruitSmoothie.UnitTests
{
    public class GetNameTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void should_return_smoothie_name()
        {
            //Arrange
            var Ingredients = new string[] { "Banana", "Strawberries" };
            Smoothie smoothie = new Smoothie(Ingredients);

            //Act
            string name = smoothie.GetName();

            //Assert
            Assert.That(name, Is.EqualTo("Banana Strawberry Fusion"));


            //Arrange
            Ingredients = new string[] { "Banana" };
            Smoothie smoothie1 = new Smoothie(Ingredients);

            //Act
            name = smoothie1.GetName();

            //Assert
            Assert.That(name, Is.EqualTo("Banana Smoothie"));
        }
    }

    public class GetPriceTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void should_return_smoothie_price()
        {
            //Arrange
            var Ingredients = new string[] { "Banana", "Strawberries" };
            Smoothie smoothie = new Smoothie(Ingredients);

            //Act
            double price = smoothie.GetPrice();

            //Assert
            Assert.That(price, Is.EqualTo(5));

            //Arrange
            Ingredients = new string[] { "Banana" };
            Smoothie smoothie1 = new Smoothie(Ingredients);

            //Act
            price = smoothie1.GetPrice();

            //Assert
            Assert.That(price, Is.EqualTo(1.25));
        }
    }

    public class GetCostTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void should_return_smoothie_cost()
        {
            //Arrange
            var Ingredients = new string[] { "Banana", "Strawberries" };
            Smoothie smoothie = new Smoothie(Ingredients);

            //Act
            double cost = smoothie.GetCost();

            //Assert
            Assert.That(cost, Is.EqualTo(2));

            //Arrange
            Ingredients = new string[] { "Banana" };
            Smoothie smoothie1 = new Smoothie(Ingredients);

            //Act
            cost = smoothie1.GetCost();

            //Assert
            Assert.That(cost, Is.EqualTo(0.5));
        }
    }
}
